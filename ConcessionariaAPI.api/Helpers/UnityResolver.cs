﻿using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;
using Unity.Exceptions;

namespace ConcessionariaAPI.api.Helpers
{
    public class UnityResolver : IDependencyResolver
    {
        protected IUnityContainer _container;


        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            this._container = container;
           
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);

            }
            catch (ResolutionFailedException)
            {
                return null;
            }

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }
    }
}