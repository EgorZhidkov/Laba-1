﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;

namespace lab3
{
    public class SimpleListItem<T>
    {
      public T data { get; set; }
      public SimpleListItem<T> next { get; set; }
      public SimpleListItem(T param)
      {
        this.data = param;
      }
    }
}

