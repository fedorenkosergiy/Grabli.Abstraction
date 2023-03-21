namespace Grabli.Abstraction
{
	public interface Validator<Target, Report>
	{
		bool IsValid(in Target toValidate, out Report output);
	}
}
