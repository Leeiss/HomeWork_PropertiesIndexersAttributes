﻿#define DEBUG_ACCOUNT
using System;
using System.Reflection;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЗадание 14.1 ");
            Account account = new Account(TypeAccount.accountCurrent, 2040000);
            account.Withdraw(4234);
            account.DumpToScreen();
            Console.WriteLine();

            Console.WriteLine("\tДомашнее задание 14.1 ");
            MemberInfo typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (object attrObj in attrs)
            {
                if (attrObj is DeveloperInfo2Attribute attr)
                {
                    Console.WriteLine($"Разработчик класса \"Building\"  -- {attr.NameDeveloper}");
                    Console.WriteLine($"Организация  -- {attr.NameOrganization}");
                }
            }
            Console.ReadKey();
        }
    }
}