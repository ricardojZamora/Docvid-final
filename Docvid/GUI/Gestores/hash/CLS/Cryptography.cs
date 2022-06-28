using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docvid.GUI.Gestores.hash.CLS
{
    class Cryptography
    {
        // encriptando
        public static string EncryptWithPublicKey(string PEMFileName, string Text)
        {
            byte[] BytesToOperateOn = Encoding.UTF8.GetBytes(Text);
            TextReader reader = File.OpenText(PEMFileName);
            AsymmetricKeyParameter KeyPair = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();

            OaepEncoding Engine = new OaepEncoding(new RsaEngine(), new Sha256Digest(), new Sha256Digest(), null);
            Engine.Init(true, KeyPair);  //if encryption is true use public key else use private
            byte[] Output = Engine.ProcessBlock(BytesToOperateOn, 0, BytesToOperateOn.Length);
            string Result = Convert.ToBase64String(Output);
            return Result;
        }
        public static string DecryptWithPrivateKey(string PEMFileName, string Text)
        {
            byte[] BytesToOperateOn = Convert.FromBase64String(Text);
            TextReader reader = File.OpenText(PEMFileName);
            AsymmetricKeyParameter KeyPair = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();

            OaepEncoding Engine = new OaepEncoding(new RsaEngine(), new Sha256Digest(), new Sha256Digest(), null);
            Engine.Init(false, KeyPair);  //if encryption is true use public key else use private
            string Result = Encoding.UTF8.GetString(Engine.ProcessBlock(BytesToOperateOn, 0, BytesToOperateOn.Length));
            return Result;
        }

    }
}
