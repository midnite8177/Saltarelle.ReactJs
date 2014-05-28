﻿using System;

using System.Html;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Serialization;
using System.Diagnostics;

namespace ReactJs
{     
   public class ReactClass
   {
      [InlineCode("{this}()")]                                 public ReactComponent New() { return null; }
      [InlineCode("{this}({props})")]                          public ReactComponent New(object props) { return null; }           
      [InlineCode("{this}({props},{children})"), ExpandParams] public ReactComponent New(object props, params object[] children) { return null; }     
   }      
}






