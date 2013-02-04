using Nancy;

namespace NancyBrownBag.Code
{
    #region 01. Message Service Interface

    //public interface IMessageService
    //{
    //    void Send();
    //}

    #endregion

    #region 02. Custom Implementation of Message Service

    //public class MessageService : IMessageService
    //{
    //    public void Send()
    //    {
    //    }
    //}

    #endregion

    /// <summary>
    /// Nancy Module demonstrating the user of the bootstrapper.
    /// </summary>
    public class BootstrapperModule : NancyModule
    {
        #region 03. AutoRegister Using TinyIoC

        //public BootstrapperModule(IMessageService messageService)
        //{
        //    Get["/foo"] = parameters =>
        //    {
        //        // Send the message based in AutoRegister injected concrete class.
        //       messageService.Send();

        //       return "Message sent!";
        //    };
        //}

        #endregion
    }

    #region 04. Example Bootstrapper Using StructureMap

    //public static class StructureMapContainer
    //{
    //    public static void Configure(IContainer container)
    //    {
    //        container.Configure(config => config.Scan(c =>
    //        {
    //            c.TheCallingAssembly();
    //            c.WithDefaultConventions();
    //        }));
    //    }
    //}

    //public class NancyBootstrapper : StructureMapNancyBootstrapper
    //{
    //    protected override void ConfigureApplicationContainer(StructureMap.IContainer existingContainer)
    //    {
    //        StructureMapContainer.Configure(existingContainer);
    //    }
    //}

    #endregion
}