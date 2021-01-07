using HotChocolate.Types;

namespace AppAny.HotChocolate.FluentValidation.Benchmarks
{
	public class TestMutationWithDarkHillsValidationType : ObjectType
	{
		protected override void Configure(IObjectTypeDescriptor descriptor)
		{
			descriptor.Field("test")
				.Argument("input", argument => argument.Type<TestInputType>())
				.Resolve("test");
		}
	}
}
