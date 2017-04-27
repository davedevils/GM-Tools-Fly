using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GM_Tools
{
    public class ResManager
    {
        public struct StructResReader
        {
            public short nFileNameLength;
            public string strFileName;
            public int nFileSize;
            public TimeSpan time_;
            public int nFilePosition;
            public string strFileContents;
        }

        public StructResReader[] SubFiles;
        public int nTotalFiles;

        public void LoadRes( string strResourceName )
        {
            FileStream ResDataInto;
            ResDataInto = File.OpenRead(strResourceName);
            BinaryReader byteread = new BinaryReader(ResDataInto);

            byte byEncryptionKey    = byteread.ReadByte();
            bool bEncryption        = byteread.ReadByte() != 0;
            int  nFileHeaderSize    = byteread.ReadInt32();
            byte[] byFileHeader    = byteread.ReadBytes(nFileHeaderSize);
            //Decryptage de La Table des fichiers
            for (int i = 0; i < nFileHeaderSize; i++)
            {
                byFileHeader[i] = (byte)((16 * (byEncryptionKey ^ (byte)~byFileHeader[i])) | ((byEncryptionKey ^ (byte)~byFileHeader[i]) >> 4));
            }
            BinaryReader BrDecryptTableFile       = new BinaryReader(new MemoryStream(byFileHeader));
            byte[] byVersion                    = BrDecryptTableFile.ReadBytes(7); 
            int  nFileNumber                    = BrDecryptTableFile.ReadInt16();

           SubFiles = new StructResReader[nFileNumber];
            nTotalFiles = nFileNumber;
            for (int i = 0; i < nFileNumber; i++)
            {
                SubFiles[i].nFileNameLength = BrDecryptTableFile.ReadInt16();
                SubFiles[i].strFileName     = Encoding.ASCII.GetString(BrDecryptTableFile.ReadBytes(SubFiles[i].nFileNameLength));
                SubFiles[i].nFileSize       = BrDecryptTableFile.ReadInt32();
                SubFiles[i].time_           = TimeSpan.FromSeconds(BrDecryptTableFile.ReadInt32());
                SubFiles[i].nFilePosition   = BrDecryptTableFile.ReadInt32();

                byteread.BaseStream.Seek(SubFiles[i].nFilePosition, SeekOrigin.Begin);

                byte[] byFileContents = byteread.ReadBytes(SubFiles[i].nFileSize);

                if (bEncryption)
                {
                    // si fichier est crypter on utilise la clé + les fonctions algebre 
                    for (int j = 0; j < SubFiles[i].nFileSize; j++)
                    {
                        byFileContents[j] = (byte)((16 * (byEncryptionKey ^ (byte)~byFileContents[j])) | ((byEncryptionKey ^ (byte)~byFileContents[j]) >> 4));
                    }
                }

                SubFiles[i].strFileContents = Encoding.ASCII.GetString(byFileContents);
            }
        }

        public void SaveAllDecryptRes()
        {
            System.IO.Directory.CreateDirectory("ExtractedRes");
            for (int i = 0; i < nTotalFiles; i++)
            {
                string FilePath = "ExtractedRes/" + SubFiles[i].strFileName;
                using (System.IO.FileStream fs = System.IO.File.Create(FilePath))
                {
                    SubFiles[i].strFileContents = SubFiles[i].strFileContents.Replace("\x00", "");
                    byte[] byFileContent = Encoding.ASCII.GetBytes(SubFiles[i].strFileContents);
                    fs.Write(byFileContent, 0, byFileContent.Length);
                    fs.Close();
                }
            }
           
        }

        public void EmptyMemory()
        {
            SubFiles = null;
            nTotalFiles = 0;
        }

    }
}
