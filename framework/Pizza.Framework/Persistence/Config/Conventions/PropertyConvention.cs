using System;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using Pizza.Persistence.Attributes;
using Pizza.Utils;

namespace Pizza.Framework.Persistence.Config.Conventions
{
    public class PropertyConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            // Default behaviour: any column can be null

            if (instance.Property.MemberInfo.GetAttribute<AllowNullAttribute>() != null)
            {
                instance.Nullable();
            }
            else
            {
                instance.Not.Nullable();
            }

            if (instance.Type == typeof(DateTime))
            {
                instance.CustomSqlType("DateTime2");
            }
            
            if (instance.Type == typeof(DateTime?))
            {
                instance.Nullable();
                instance.CustomSqlType("DateTime2");
            }
        }
    }
}