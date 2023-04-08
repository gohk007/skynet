using System.Runtime.Serialization;

namespace Infrastructure.Data
{
    [Serializable]
    internal class NotFoundException : Exception
    {
        private string v1;
        private string v2;



        //public NotFoundException(string message, Exception innerException) : base(message, innerException)
        //{
        //}

        public NotFoundException()
        {
        }

        public NotFoundException(string? message) : base(message)
        {
        }

        public NotFoundException(string? message1, int? message2) 
        {
        }




    }
}