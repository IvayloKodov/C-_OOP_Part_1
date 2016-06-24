﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class ImmutableList
{
    public List<int> collection;

    public ImmutableList(List<int> collection = null)
    {
        if (collection == null)
        {
            this.collection = new List<int>();
        }
        else
        {
            this.collection = collection;
        }
    }

    public ImmutableList Get()
    {
        List<int> newCollection = new List<int>(this.collection);
        ImmutableList newImmutable = new ImmutableList(newCollection);
        return newImmutable;
    }
}

public class StartUp
{
    public static void Main()
    {
        Type immutableList = typeof(ImmutableList);
        FieldInfo[] fields = immutableList.GetFields();
        if (fields.Length < 1)
        {
            throw new Exception();
        }
        else
        {
            Console.WriteLine(fields.Length);
        }

        MethodInfo[] methods = immutableList.GetMethods();
        bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("ImmutableList"));
        if (!containsMethod)
        {
            throw new Exception();
        }
        else
        {
            Console.WriteLine(methods.Length);
        }
    }
}