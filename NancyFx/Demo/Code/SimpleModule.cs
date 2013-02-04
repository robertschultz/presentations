using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyBrownBag.Code
{
    /// <summary>
    /// Simple Nancy module to demonstrate registering routes using different verbs.
    /// </summary>
    public class SimpleModule : NancyModule
    {
        #region 01. Simple Route

        //public SimpleModule()
        //{
        //    Get["/foo"] = parameters =>
        //    {
        //        return "Welcome to Nancy!";
        //    };
        //}

        #endregion

        #region 02. Route with a Base Constructor

        //public SimpleModule() : base("/foo")
        //{
        //    Get["/bar"] = parameters =>
        //    {
        //        return "Welcome to Nancy!";
        //    };
        //}

        #endregion

        #region 03. Routes with Parameters

        //public SimpleModule() : base("/foo")
        //{
        //    Get["/bar/{name}"] = parameters =>
        //    {
        //        return string.Format("Welcome to Nancy {0}!", parameters.name);
        //    };
        //}

        #endregion

        #region 04. Post Route

        //public SimpleModule() : base("/foo")
        //{
        //    Post["/bar"] = parameters =>
        //    {
        //        return "Welcome to Nancy! Thanks for posting.";
        //    };
        //}

        #endregion
    }
}