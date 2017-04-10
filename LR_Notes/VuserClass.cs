using LoadRunner;

namespace CIFromWF
{
    public class VuserClass
    {
        LrApi lr;
        public VuserClass()
        {
            lr = new LrApi();
        }
        public int Initialize()
        {
            return lr.PASS;
        }

        public int Actions()
        {
            return lr.PASS;
        }

        public int Terminate()
        {
            return lr.PASS;
        }
    }
}