class Hasher
{
static int hasher = -1;
static MD5 hashAlgo = null;

static Hasher()
{
hashAlgo = new MD5CryptoServiceProvider();
}

public static int getHashOverFolder(String path)
{
dfs(path);
return hasher;
}

static void dfs(String path)
{
foreach (var x in Directory.GetFiles(path))
{
using (FileStream file = new FileStream(x, FileMode.Open, FileAccess.Read))
{
byte[] retVal = hashAlgo.ComputeHash(file);

StringBuilder sb = new StringBuilder();
foreach (var y in retVal)
sb.Append(y);

hasher ^= sb.ToString().GetHashCode();
}
}

foreach (var y in Directory.GetDirectories(path))
dfs(y);
}
}
