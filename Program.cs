using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyenv_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 获取当前计算机登陆的用户
            #region
            string username = Environment.UserName;
            Console.WriteLine($"当前用户:{username}");
            #endregion
            // 获取用户环境信息
            #region
            Console.WriteLine($"{username}的用户变量:\n---------------------------------------------------------------------------");
            IDictionary environmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
            foreach (DictionaryEntry de in environmentVariables)
            {
                Console.WriteLine("{0} = {1}",de.Key,de.Value);
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            #endregion

            // 获取系统环境变量
            Console.WriteLine($"系统变量:\n----------------------------------------------------------------------------------");
            #region
            IDictionary dictionary = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);
            foreach (DictionaryEntry de in dictionary)
            {
                Console.WriteLine($"{de.Key} = {de.Value}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            #endregion

        }
    }
}
