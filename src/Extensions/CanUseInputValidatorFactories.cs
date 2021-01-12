using System.Linq;

namespace AppAny.HotChocolate.FluentValidation
{
	public static class CanUseInputValidatorFactories
	{
		/// <summary>
		/// Adds default <see cref="InputValidatorFactory"/>. See <see cref="ValidationDefaults.InputValidatorFactories.Default"/>
		/// </summary>
		public static TConfigurator UseDefaultInputValidatorFactory<TConfigurator>(
			this CanUseInputValidatorFactories<TConfigurator> configurator,
			params InputValidatorFactory[] inputValidatorFactories)
		{
			return configurator.UseInputValidatorFactories(
				new InputValidatorFactory[] { ValidationDefaults.InputValidatorFactories.Default }
					.Concat(inputValidatorFactories)
					.ToArray());
		}
	}
}