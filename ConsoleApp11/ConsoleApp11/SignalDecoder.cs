using System;

using System.IO;

using System.Text;


namespace ConsoleApp11
{
    public class SignalDecoder: IDisposable
    {
        
        private FileStream stream;
        
        public SignalDecoder()
        {
            stream = null;            
        }

        public SignalDecoder(string path) : this()
        {
            Open(path);
        }       

        ~SignalDecoder()
        {
            Close();
        }

        public void Open(string path)
        {
            // Make sure we are in a valid state
            Close();

            // Clear blocks
            //Blocks.Clear();

            // Get full path
            //path = Path.GetFullPath(path);

            // Open a stream
            stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            // Read identification block
            //Identification = serializer.Deserialize<IdentificationBlock>(stream);

            // Read header block
            //Header = serializer.Deserialize<HeaderBlock>(stream);

            // Read block(s)
            string id = "";
            //Block block = null;
            long position = 0L;



            
            using var sr = new StreamReader(stream, Encoding.UTF8);

            string line = String.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }


            //while ((id = Peek(ref stream)) != null)
            //{
            //    // Deserialize block
            //    //position = stream.Position;

            //    //switch (id)
            //    //{
            //    //    case "##AT": block = serializer.Deserialize<AttachmentBlock>(stream); break;
            //    //    case "##EV": block = serializer.Deserialize<EventBlock>(stream); break;
            //    //    case "##HD": block = serializer.Deserialize<HeaderBlock>(stream); break;
            //    //    case "##MD": block = serializer.Deserialize<MetadataBlock>(stream); break;
            //    //    case "##TX": block = serializer.Deserialize<TextBlock>(stream); break;
            //    //    case "##FH": block = serializer.Deserialize<FileHistoryBlock>(stream); break;
            //    //    case "##DG": block = serializer.Deserialize<DataGroupBlock>(stream); break;
            //    //    case "##CG": block = serializer.Deserialize<ChannelGroupBlock>(stream); break;
            //    //    case "##SI": block = serializer.Deserialize<SourceInformationBlock>(stream); break;
            //    //    case "##CN": block = serializer.Deserialize<ChannelBlock>(stream); break;
            //    //    case "##CC":

            //    //        // Need to extract block to know conversion type
            //    //        var channelConversionBlock = serializer.Deserialize<ChannelConversionBlock>(stream);

            //    //        // Reset stream to position before deserialization
            //    //        stream.Position = position;

            //    //        //Read actual conversion block
            //    //        switch (channelConversionBlock.ConversionType)
            //    //        {
            //    //            case Enums.ConversionType.None: block = serializer.Deserialize<ChannelConversionBlock>(stream); break;
            //    //            case Enums.ConversionType.Linear: block = serializer.Deserialize<ChannelConversionBlockLinear>(stream); break;
            //    //            case Enums.ConversionType.TabularValueToTextOrScale: block = serializer.Deserialize<ChannelConversionTabularToText>(stream); break;
            //    //            default: block = serializer.Deserialize<PlainBlock>(stream); break;
            //    //        }

            //    //        break;

            //    //    case "##DT": block = serializer.Deserialize<DataBlock>(stream); break;
            //    //    case "##DL": block = serializer.Deserialize<DataListBlock>(stream); break;
            //    //    default: block = serializer.Deserialize<PlainBlock>(stream); break;
            //    //}

            //    //block.Position = position;

            //    //// Workaround for data list block
            //    //if (block is DataListBlock)
            //    //{
            //    //    var before = stream.Position;

            //    //    while (!(Peek(ref stream, 2) == "##"))
            //    //    {
            //    //        stream.Position += 2;
            //    //    }

            //    //    var after = stream.Position;
            //    //    var difference = after - before;

            //    //    stream.Position = before;

            //    //    var debug = Peek(ref stream, (int)(difference + 4)).Replace("\0", ".");

            //    //    stream.Position = after;
            //    //}

            //    //// Save block
            //    //Blocks.Add(position, block);
            //}
        }

        private string Peek(ref FileStream stream)
        {
            if (stream == null)
            {
                return null;
            }

            if (stream.Position >= stream.Length)
            {
                return null;
            }

            if (stream.Length - stream.Position < 4)
            {
                return null;
            }

            byte[] buffer = new byte[4];

            stream.Read(buffer, 0, 4);
            stream.Position = stream.Position - 4;

            return System.Text.Encoding.ASCII.GetString(buffer);
        }

        public void Close()
        {
            stream?.Close();
            stream = null;
        }

        public void Dispose()
        {
            Close();
        }
    }
}
