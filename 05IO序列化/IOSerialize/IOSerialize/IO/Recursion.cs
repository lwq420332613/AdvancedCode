using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IOSerialize.IO
{
    public class Recursion
    {
        /// <summary>
        /// 找出全部的子文件夹
        /// </summary>
        /// <param name="rootPath">根目录</param>
        /// <returns></returns>
        public static List<DirectoryInfo> GetAllDirectory(string rootPath)
        {
            if (!Directory.Exists(rootPath))
                return new List<DirectoryInfo>();

            List<DirectoryInfo> directoryList = new List<DirectoryInfo>();//容器

            DirectoryInfo directory = new DirectoryInfo(rootPath);//root文件夹
            directoryList.Add(directory);

            GetChildDirectory(directoryList, directory);

            //DirectoryInfo[] directoryListChild = directory.GetDirectories();//一级子文件夹
            //directoryList.AddRange(directoryListChild);

            //foreach (var directoryChild in directoryListChild)
            //{
            //    DirectoryInfo[] directoryListChildChild = directoryChild.GetDirectories();//二级子文件夹
            //    directoryList.AddRange(directoryListChildChild);

            //    foreach (var directoryChildChild in directoryListChildChild)
            //    {
            //        DirectoryInfo[] directoryListChildChildChild = directoryChildChild.GetDirectories();////三级子文件夹
            //        directoryList.AddRange(directoryListChildChildChild);
            //        //......  //。。。。级子文件夹。。。。。。
            //    }
            //}
            return directoryList;
        }

        private static void GetChildDirectory(List<DirectoryInfo> directoryList, DirectoryInfo directoryParent)
        {
            DirectoryInfo[] directoryListChild = directoryParent.GetDirectories();//一级子文件夹
            if (directoryListChild != null && directoryListChild.Length > 0)//递归的跳出条件
            {
                directoryList.AddRange(directoryListChild);
                foreach (var child in directoryListChild)
                {
                    GetChildDirectory(directoryList, child);
                }
            }
        }




        ///// <summary>
        ///// 递归很耗内存
        ///// </summary>
        ///// <param name="directoryList"></param>
        ///// <param name="directoryParent"></param>
        //private static void GetChildDirectory(List<DirectoryInfo> directoryList, DirectoryInfo directoryParent)
        //{
        //    DirectoryInfo[] directoryListChild = directoryParent.GetDirectories();//一级子文件夹
        //    directoryList.AddRange(directoryListChild);

        //    if (directoryListChild.Length > 0)//跳出条件
        //    {
        //        foreach (var directoryChild in directoryListChild)
        //        {
        //            GetChildDirectory(directoryList, directoryChild);//方法自身调用自身  递归
        //        }
        //    }
        //}

        /// <summary>
        /// 错误做法错误做法错误做法错误做法
        /// 不要滥用递归
        ///可以等待
        ///内存爆掉
        /// </summary>
        private void Wait()
        {
            if (DateTime.Now.Millisecond < 999)
            {
                //启动个多线程
                Wait();
                Thread.Sleep(5);//最多可能浪费4ms
            }
            else
                return;

        }
    }
}
