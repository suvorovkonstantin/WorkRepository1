using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLA001
{
    public class RequestState
    {
        // This class stores the state of the request.
        const int BUFFER_SIZE = 1024;
        public StringBuilder requestData;
        public byte[] bufferRead;
        public WebRequest request;
        public WebResponse response;
        public Stream responseStream;
        public RequestState()
        {
            bufferRead = new byte[BUFFER_SIZE];
            requestData = new StringBuilder("");
            request = null;
            responseStream = null;
        }
    }
    /*
    public class Temper
    {
        public async Task RefTest()
        {
            WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
            // Get the response.
            WebResponse response = request.g;
            // Display the status.
            //IAsyncResult asyncres = (IAsyncResult)request.BeginGetResponse(new AsyncCallback());
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
        }

        private static void RespCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                // Set the State of request to asynchronous.
                RequestState myRequestState = (RequestState)asynchronousResult.AsyncState;
                WebRequest myWebRequest1 = myRequestState.request;
                // End the Asynchronous response.
                myRequestState.response = myWebRequest1.EndGetResponse(asynchronousResult);
                // Read the response into a 'Stream' object.
                Stream responseStream = myRequestState.response.GetResponseStream();
                myRequestState.responseStream = responseStream;
                // Begin the reading of the contents of the HTML page and print it to the console.
                IAsyncResult asynchronousResultRead = responseStream.BeginRead(myRequestState.bufferRead, 0, myRequestState.bufferRead, new AsyncCallback(ReadCallBack), myRequestState);

            }
            catch (WebException e)
            {
                Console.WriteLine("WebException raised!");
                Console.WriteLine("\n{0}", e.Message);
                Console.WriteLine("\n{0}", e.Status);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception raised!");
                Console.WriteLine("Message : " + e.Message);
            }
        }
    }
*/
    public class Temper : MainPage
    {
        public void StartTask()
        {
            var t = new Task(() =>
            {
                MessageBox.Show("async show");
            }
            );
            t.Start();
            t.Wait();
        }
    }
}
