using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.ModelBinding;

namespace NancyBrownBag.Code
{
    /// <summary>
    /// Nancy Module to demonstrate different ways of model binding within Nancy.
    /// </summary>
    public class ModelBindingModule : NancyModule
    {
        #region 01. User Model

        //public class User
        //{
        //    /// <summary>
        //    /// Gets or sets the username.
        //    /// </summary>
        //    /// <value>
        //    /// The username.
        //    /// </value>
        //    public string Username { get; set; }

        //    /// <summary>
        //    /// Gets or sets the password.
        //    /// </summary>
        //    /// <value>
        //    /// The password.
        //    /// </value>
        //    public string Password { get; set; }

        //    /// <summary>
        //    /// Gets or sets the age.
        //    /// </summary>
        //    /// <value>
        //    /// The age.
        //    /// </value>
        //    public int Age { get; set; }
        //}

        #endregion

        #region 02. Basic Binding

        //public ModelBindingModule()
        //{
        //    Post["/foo"] = parameters =>
        //    {
        //        User model = this.Bind();

        //        return string.Format("Your username is {0} and password is {1}.", model.Username, model.Password);
        //    };
        //}

        #endregion

        #region 03. Generic Binding

        //public ModelBindingModule()
        //{
        //    Post["/foo"] = parameters =>
        //    {
        //        var model = this.Bind<User>();

        //        return string.Format("Your username is {0} and password is {1}.", model.Username, model.Password);
        //    };
        //}

        #endregion
            
        #region 04. Blacklisted Model Properties

        //public ModelBindingModule()
        //{
        //    Post["/foo"] = parameters =>
        //    {
        //        var model = this.Bind<User>("Password");

        //        return string.Format("Your username is {0} and password is {1}.", model.Username, model.Password);
        //    };
        //}

        #endregion
    }
}