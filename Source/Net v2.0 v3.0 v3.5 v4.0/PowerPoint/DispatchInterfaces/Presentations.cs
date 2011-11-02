//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Presentations SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Presentations : Collection
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Presentations);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Presentation this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="WithWindow">NetOffice.OfficeApi.Enums.MsoTriState WithWindow</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Presentation Add(NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(withWindow);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="ReadOnly">NetOffice.OfficeApi.Enums.MsoTriState ReadOnly</param>
		/// <param name="Untitled">NetOffice.OfficeApi.Enums.MsoTriState Untitled</param>
		/// <param name="WithWindow">NetOffice.OfficeApi.Enums.MsoTriState WithWindow</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Presentation Open(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="ReadOnly">NetOffice.OfficeApi.Enums.MsoTriState ReadOnly</param>
		/// <param name="Untitled">NetOffice.OfficeApi.Enums.MsoTriState Untitled</param>
		/// <param name="WithWindow">NetOffice.OfficeApi.Enums.MsoTriState WithWindow</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Presentation OpenOld(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "OpenOld", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public void CheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "CheckOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public bool CanCheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "CanCheckOut", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="ReadOnly">NetOffice.OfficeApi.Enums.MsoTriState ReadOnly</param>
		/// <param name="Untitled">NetOffice.OfficeApi.Enums.MsoTriState Untitled</param>
		/// <param name="WithWindow">NetOffice.OfficeApi.Enums.MsoTriState WithWindow</param>
		/// <param name="OpenAndRepair">NetOffice.OfficeApi.Enums.MsoTriState OpenAndRepair</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Presentation Open2007(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow, NetOffice.OfficeApi.Enums.MsoTriState openAndRepair)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow, openAndRepair);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}