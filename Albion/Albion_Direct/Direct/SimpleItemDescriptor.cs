////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: b0 */
    public partial class SimpleItemDescriptor : ItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private b0 _internal;
        
        #region Properties
        
        public b0 SimpleItemDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public SimpleItemDescriptor(b0 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SimpleItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator b0(SimpleItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimpleItemDescriptor(b0 instance)
        {
            return new SimpleItemDescriptor(instance);
        }
        
        public static implicit operator bool(SimpleItemDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
