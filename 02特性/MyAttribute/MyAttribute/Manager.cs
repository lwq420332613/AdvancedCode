using MyAttribute.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    public class Manager
    {
        public static void Show(Student student)
        {
            Type type = typeof(Student); //student.GetType();
            if (type.IsDefined(typeof(CustomAttribute), true))//检查有没有  性能高
            {
                CustomAttribute attribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute), true);
                Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
                attribute.Show();
            }

            PropertyInfo property = type.GetProperty("Id");
            if (property.IsDefined(typeof(CustomAttribute), true))
            {
                CustomAttribute attribute = (CustomAttribute)property.GetCustomAttribute(typeof(CustomAttribute), true);
                Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
                attribute.Show();
            }

            MethodInfo method = type.GetMethod("Answer");
            if (method.IsDefined(typeof(CustomAttribute), true))
            {
                CustomAttribute attribute = (CustomAttribute)method.GetCustomAttribute(typeof(CustomAttribute), true);
                Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
                attribute.Show();
            }

            ParameterInfo parameter = method.GetParameters()[0];
            if (parameter.IsDefined(typeof(CustomAttribute), true))
            {
                CustomAttribute attribute = (CustomAttribute)parameter.GetCustomAttribute(typeof(CustomAttribute), true);
                Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
                attribute.Show();
            }

            ParameterInfo returnParameter = method.ReturnParameter;
            if (returnParameter.IsDefined(typeof(CustomAttribute), true))
            {
                CustomAttribute attribute = (CustomAttribute)returnParameter.GetCustomAttribute(typeof(CustomAttribute), true);
                Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
                attribute.Show();
            }


            ////做数据检查(可以写在数据库保存方法)
            //if (student.QQ > 10001 && student.QQ < 999999999999)
            //{

            //}
            //else
            //{

            //}

            student.Validate();

            student.Study();
            string result = student.Answer("Eleven");
        }
    }
}
