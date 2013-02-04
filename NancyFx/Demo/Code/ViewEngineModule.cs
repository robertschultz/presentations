using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyBrownBag.Code
{
    /// <summary>
    /// Nancy Module demonstrating use cases with the SuperSimpleViewEngine.
    /// </summary>
    public class ViewEngineModule : NancyModule
    {
        #region 01. View Engine No Model

        //public ViewEngineModule()
        //{
        //    Get["/foo"] = parameters =>
        //    {
        //        return View["foo.html"];
        //    };
        //}

        #endregion

        #region 02. View Engine Anonymous Model

        //public ViewEngineModule()
        //{
        //    Get["/foo"] = parameters =>
        //    {
        //        return View[
        //            "foo.html",
        //            new { @Username = "Rschultz" }
        //        ];
        //    };
        //}

        #endregion

        #region 03. View Engine Custom Model

        //public class CustomUser
        //{
        //    /// <summary>
        //    /// Gets or sets the username.
        //    /// </summary>
        //    /// <value>
        //    /// The username.
        //    /// </value>
        //    public string Username { get; set; }

        //    /// <summary>
        //    /// Gets or sets the age.
        //    /// </summary>
        //    /// <value>
        //    /// The age.
        //    /// </value>
        //    public int Age { get; set; }
        //}

        //public ViewEngineModule()
        //{
        //    Get["/foo/bar"] = parameters =>
        //    {
        //        return View[
        //            "bar.html", 
        //            new CustomUser { Username = "Rschultz", Age = 32 }
        //        ];
        //    };
        //}

        #endregion
    }
}