using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Linq;

namespace SwaggerAPI
{
    public class ApiExplorerVersionConvention : IControllerModelConvention
    {
        //This class modifies our app to follow different conventions from the default MVC behavior
        public void Apply(ControllerModel controller)
        {
            //Take the last name of the namespace
            var controllerNamespace = controller.ControllerType.Namespace; // e.g. "Controllers.v1"  
            var apiVersion = controllerNamespace.Split('.').Last().ToLower();


            //Group name is declared globally
            controller.ApiExplorer.GroupName = apiVersion;
        }
    }
}
