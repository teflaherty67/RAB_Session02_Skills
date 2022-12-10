#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace RAB_Session02_Skills
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            string[] myStringArray = new string[4];
            List<string> myStringList = new List<string>();

            myStringArray[0] = "This is the first item";
            myStringArray[1] = "12312";
            myStringArray[2] = "This is the third item";
            myStringArray[3] = "This is the last item";
            //myStringArray[4] = "adfasdfasdfasf";

            myStringList.Add("This is the first item");
            myStringList.Add("This is the second item");

            myStringList.RemoveAt(0);

            List<string[]> myArrayList = new List<string[]>();
            myArrayList.Add(myStringArray);

            foreach(string myString in myStringArray)
            {
                TaskDialog.Show("Test", myString);
            }

            foreach(string myString2 in myStringList)
            {
                TaskDialog.Show("Test", myString2);
            }

            foreach (string[] myArray in myArrayList)
            {
                string comboString = "";

                foreach(string myString3 in myArray)
                {
                    comboString = comboString + myString3;
                }

                Debug.Print("******" + comboString);
            }

            return Result.Succeeded;
        }
    }
}
