﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   This program can be provided to you by Xceed Software Inc. under a
   proprietary commercial license agreement for use in non-Open Source
   projects. The commercial version of Extended WPF Toolkit also includes
   priority technical support, commercial updates, and many additional 
   useful WPF controls if you license Xceed Business Suite for WPF.

   Visit http://xceed.com and follow @datagrid on Twitter.

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xceed.Wpf.DataGrid
{
  public delegate void DataGridCurrentChangingEventHandler( object sender, DataGridCurrentChangingEventArgs e );

  public class DataGridCurrentChangingEventArgs : CancelRoutedEventArgs
  {
    internal DataGridCurrentChangingEventArgs( DataGridContext oldDataGridContext, object oldCurrent, DataGridContext newDataGridContext, object newCurrent, bool isCancelable )
      : base( DataGridControl.CurrentChangingEvent )
    {
      this.IsCancelable = isCancelable;
      this.OldDataGridContext = oldDataGridContext;
      this.OldCurrent = oldCurrent;
      this.NewDataGridContext = newDataGridContext;
      this.NewCurrent = newCurrent;
    }

    public bool IsCancelable
    {
      get;
      private set;
    }

    public DataGridContext OldDataGridContext
    {
      get;
      private set;
    }

    public object OldCurrent
    {
      get;
      private set;
    }

    public DataGridContext NewDataGridContext
    {
      get;
      private set;
    }

    public object NewCurrent
    {
      get;
      private set;
    }
  }
}