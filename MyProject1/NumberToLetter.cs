namespace MyProject1
{
    public class NumberToLetter
    {
        public char ChangeNumberToLetter(int i)
        {
            char le;
            if (i % 96 != 0 && i%96<27)
            {
                int l = i + 96;
                le = (char) l;
                return le;

            }
            else
            {
                return '0';
            }
           
        }
    }
}