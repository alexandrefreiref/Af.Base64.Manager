namespace Base64.Manager
{
    public class Action
    {
        // Example Base64.Manager.Action.Encode("test.jpg")
        //public static string ConvertFromFile(string path)
        //{
        //    string base64Representation = "";
        //    try
        //    {
        //        if (path != null)
        //        {
        //            byte[] fileArray = System.IO.File.ReadAllBytes(path);
        //            base64Representation = System.Convert.ToBase64String(fileArray);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return base64Representation;
        //}
        public static string Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
