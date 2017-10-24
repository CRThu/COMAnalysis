using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMv2
{
    partial class MainForm
    {
        // 
        string ByteIsString(byte[] ByteArray)
        {
            return System.Text.Encoding.Default.GetString(ByteArray);
        }

        Int16[] ByteIsInt16(byte[] ByteArray)
        {
            Int16[] Int16Array = new Int16[ByteArray.Length / 2];
            if (ByteArray.Length % 2 == 0)
                for (int i = 0; i < ByteArray.Length; i += 2)
                    Int16Array[i / 2] = BitConverter.ToInt16(ByteArray, i);
            return Int16Array;
        }

        Int32[] ByteIsInt32(byte[] ByteArray)
        {
            Int32[] Int32Array = new Int32[ByteArray.Length / 4];
            if (ByteArray.Length % 4 == 0)
                for (int i = 0; i < ByteArray.Length; i += 4)
                    Int32Array[i / 4] = BitConverter.ToInt32(ByteArray, i);
            return Int32Array;
        }

        // 选择解析器
        void ByteDecoder()
        {

        }
    }
}
