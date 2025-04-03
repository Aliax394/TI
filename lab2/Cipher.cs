using System.Collections;
namespace ti2;

public class Cipher
{
    public BitArray Register { get; private set; }  
    public BitArray Key { get; private set; }
    public BitArray PText { get;  set; }
    public BitArray CipherB { get;private set; }

    public void makeRegister(string startReg)
    {
        Register = new BitArray(startReg.Length);
        for (int i = 0; i < startReg.Length; i++)
            Register[i] = startReg[i] == '1';
    }

    public void makeKey(int keyLen)
    {
        Key = new BitArray(keyLen);
        for (int i = 0; i < keyLen; i++)
        {
            Key[i] = Register[0];
            int len = Register.Length;
            bool next = Register[len - 1 - 27] ^ Register[len - 1 - 2];
            for (int j = 0; j < Register.Length - 1; j++)
            {
                Register[j] = Register[j + 1];
            }

            Register[Register.Length - 1] = next;
        }
    }

    public void crCipher() => CipherB = Key.Xor(PText);
    
}