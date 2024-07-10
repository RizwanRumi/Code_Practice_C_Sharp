internal class Program
{
    private static void Main(string[] args)
    {

        do
        {
            string inputIpAddress = Console.ReadLine();
            
            // for IPV4 -> "127.0.1.2"

            int length = inputIpAddress.Length;

            if (length <= 15)
            {
                bool finalResult = CheckIpAddress(inputIpAddress);

                if (finalResult)
                {
                    Console.WriteLine("IP address is valid.");
                }
                else
                {
                    Console.WriteLine("IP address is not valid");
                }
            }
            else
            {
                Console.WriteLine("Invalid ip address");
            }
        }
        while (true);

       
    }

    public static bool CheckIpAddress(string ipAddress)
    {
        bool result = false;
        
        int[] ipList = ipAddress.Split('.').Select(int.Parse).ToArray();

        if (ipList.Length != 4) return result;

        else
        {
            if ((ipList[0] >= 0 && ipList[0] < 256) && (ipList[1] >= 0 && ipList[1] < 256) &&
                (ipList[2] >= 0 && ipList[2] < 256) && (ipList[3] >= 0 && ipList[3] < 256)) 
                return result = true;
        }

        /*
         * another solution
            //for (int i = 0; i < ip.Length; i++)
            //{
            //    int temp = Convert.ToInt32(ip[i]);

            //    if (temp >= 0 && temp < 256)
            //    {
            //        result = true;
            //        continue;
            //    }
            //    else
            //    {
            //        result = false;
            //        break;
            //    }
            //}
         */


        return result;
    }
}