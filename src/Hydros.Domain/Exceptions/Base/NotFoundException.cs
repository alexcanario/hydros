namespace Hydros.Domain.Exceptions.Base;

public class NotFoundException(string message) : Exception(message) { }