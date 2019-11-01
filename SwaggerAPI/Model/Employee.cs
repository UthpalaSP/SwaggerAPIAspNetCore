namespace SwaggerAPI.Model
{
    public class Employee
    {
        /// <summary>  
        /// Employee id  
        /// </summary>  
        public int id { get; set; }

        /// <summary>  
        /// Name of the employee.  
        /// </summary>  
        public string Name { get; set; }

        /// <summary>  
        /// Employee personal address.  
        /// </summary>  
        public string Adress { get; set; }

        /// <summary>  
        /// Department unit of the employee.  
        /// </summary>  
        public string Department { get; set; }
    }
}
