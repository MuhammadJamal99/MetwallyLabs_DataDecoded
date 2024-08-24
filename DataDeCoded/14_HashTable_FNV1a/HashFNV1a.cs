using System.Numerics;
using System.Text;

namespace DataDeCoded.HashTableFunctions;
public class HashFNV1a
{
    public uint HashFNV1a32(string str)
    {
        uint offsetBasis = 2166136261;
        uint fnvPrime = 16777619;
        byte[] data = Encoding.ASCII.GetBytes(str);
        uint hash = offsetBasis;
        foreach (byte dataByte in data)
        {
            hash = hash ^ dataByte;
            hash = hash * fnvPrime;
        }
        Console.WriteLine(" Data : {0} \n Hashed Value: {1} \n Hex Hahed Value: {2}", str, hash, hash.ToString("x"));
        return hash;
    }
    public ulong HashFNV1a64(string str)
    {
        ulong offsetBasis = 14695981039346656037;
        ulong fnvPrime = 1099511628211;
        byte[] data = Encoding.ASCII.GetBytes(str);
        ulong hash = offsetBasis;
        foreach (byte dataByte in data)
        {
            hash = hash ^ dataByte;
            hash = hash * fnvPrime;
        }
        Console.WriteLine(" Data : {0} \n Hashed Value: {1} \n Hex Hahed Value: {2}", str, hash, hash.ToString("x"));
        return hash;
    }

    public BigInteger HashFNV1a128(string str)
    {
        BigInteger offsetBasis = BigInteger.Parse("144066263297769815596495629667062367629");
        BigInteger fnvPrime = BigInteger.Parse("309485009821345068724781371");
        byte[] data = Encoding.ASCII.GetBytes(str);
        BigInteger hash = offsetBasis;
        foreach (byte dataByte in data)
        {
            hash = hash ^ dataByte;
            hash = hash * fnvPrime;
        }
        Console.WriteLine(" Data : {0} \n Hashed Value: {1} \n Hex Hahed Value: {2}", str, hash, hash.ToString("x"));
        return hash;
    }
    public BigInteger HashFNV1a256(string str)
    {
        BigInteger offsetBasis = BigInteger.Parse("100029257958052580907070968620625704837092796014241193945225284501741471925557");
        BigInteger fnvPrime = BigInteger.Parse("374144419156711147060143317175368453031918731002211");
        byte[] data = Encoding.ASCII.GetBytes(str);
        BigInteger hash = offsetBasis;
        foreach (byte dataByte in data)
        {
            hash = hash ^ dataByte;
            hash = hash * fnvPrime;
        }
        Console.WriteLine(" Data : {0} \n Hashed Value: {1} \n Hex Hahed Value: {2}", str, hash, hash.ToString("x"));
        return hash;
    }
    public BigInteger HashFNV1a512(string str)
    {
        BigInteger offsetBasis = BigInteger.Parse("9659303129496669498009435400716310466090418745672637896108374329434462657994582932197716438449813051892206539805784495328239340083876191928701583869517785");
        BigInteger fnvPrime = BigInteger.Parse("35835915874844867368919076489095108449946327955754392558399825615420669938882575126094039892345713852759");
        byte[] data = Encoding.ASCII.GetBytes(str);
        BigInteger hash = offsetBasis;
        foreach (byte dataByte in data)
        {
            hash = hash ^ dataByte;
            hash = hash * fnvPrime;
        }
        Console.WriteLine(" Data : {0} \n Hashed Value: {1} \n Hex Hahed Value: {2}", str, hash, hash.ToString("x"));
        return hash;
    }
}
