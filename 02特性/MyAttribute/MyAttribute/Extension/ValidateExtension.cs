﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute.Extension
{
    public static class ValidateExtension
    {
        public static bool Validate(this object oObject)
        {
            Type type = oObject.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object[] attributeArray = prop.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                    foreach (AbstractValidateAttribute attribute in attributeArray)
                    {
                        if (!attribute.Validate(prop.GetValue(oObject)))
                        {
                            return false;//表示终止
                        }
                    }
                }

                //if (prop.IsDefined(typeof(LongAttribute), true))
                //{
                //    LongAttribute attribute = (LongAttribute)prop.GetCustomAttribute(typeof(LongAttribute), true);
                //    if (!attribute.Validate(prop.GetValue(oObject)))
                //    {
                //        return false;
                //    }
                //}
                //if (prop.IsDefined(typeof(LengAttribute), true))
                //{
                //    LengAttribute attribute = (LengAttribute)prop.GetCustomAttribute(typeof(LengAttribute), true);
                //    if (!attribute.Validate(prop.GetValue(oObject)))
                //    {
                //        return false;
                //    }
                //}
            }
            return true;
        }
    }

    public abstract class AbstractValidateAttribute : Attribute
    {
        public abstract bool Validate(object value);
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class LengAttribute : AbstractValidateAttribute
    {
        private int _Min = 0;
        private int _Max = 0;
        public LengAttribute(int min, int max)
        {
            this._Min = min;
            this._Max = max;
        }


        public override bool Validate(object value)//" "
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                int length = value.ToString().Length;
                if (length > this._Min && length < this._Max)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class LongAttribute : AbstractValidateAttribute
    {
        private long _Min = 0;
        private long _Max = 0;
        public LongAttribute(long min, long max)
        {
            this._Min = min;
            this._Max = max;
        }


        public override bool Validate(object value)//" "
        {
            //可以改成一句话
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (long.TryParse(value.ToString(), out long lResult))
                {
                    if (lResult > this._Min && lResult < this._Max)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
