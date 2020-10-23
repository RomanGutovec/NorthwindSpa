﻿using System;

namespace Application.Common.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public NotFoundException(string entityName, int identifier)
            : base($"Entity \"{entityName}\" ({identifier}) was not found.")
        {
        }
    }
}
