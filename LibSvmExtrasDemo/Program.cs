﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibSvmExtrasDemo.Demo;

namespace LibSvmExtrasDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      CSVMDemo.Run();
      NuSVMDemo.Run();
      EpsSVRDemo.Run();
      NuSVRDemo.Run();
      OneClassDemo.Run();

      Console.ReadKey();
    }
  }
}
