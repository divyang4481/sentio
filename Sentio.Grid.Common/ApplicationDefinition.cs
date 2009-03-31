using System;
using System.Reflection;

namespace Sentio.Grid.Common
{
    
    public class ApplicationDefinition
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
        protected Assembly ApplicationAssembly { get; set; }

        public ApplicationDefinition()
        {
            
        }

        public ApplicationDefinition(string filePath)
        {
            Assembly assembly = Assembly.LoadFile(filePath);
            Type[] exportedTypes = assembly.GetExportedTypes();
            foreach(Type exportedType in exportedTypes)
            {
                object[] temp = exportedType.GetCustomAttributes(typeof (ApplicationDefinitionAttribute), false);
                if (temp.Length != 0)
                {
                    ApplicationDefinitionAttribute attrib =(ApplicationDefinitionAttribute)temp[0];
                    if (attrib != null)
                    {
                        IApplicationEntry exportedTypeDefinition =
                            (IApplicationEntry)
                            exportedType.InvokeMember("", BindingFlags.CreateInstance, null, null,
                                                      null);
                        ApplicationDefinition definition = exportedTypeDefinition.GetDefinition();
                        Id = definition.Id;
                        Name = definition.Name;
                        Author = definition.Author;
                        ApplicationAssembly = assembly;
                        return;
                    }
                }
            }
            throw new Exception(Messages.InvalidApplicationNoDefinition);
        }   
    }
}