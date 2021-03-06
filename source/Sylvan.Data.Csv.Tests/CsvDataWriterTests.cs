using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Sylvan.Data.Csv
{
	public class CsvDataWriterTests
	{
		[Fact]
		public async Task Simple()
		{
			var dr = TestData.GetData();

			var sw = new StringWriter();
			var csv = new CsvDataWriter(sw);
			await csv.WriteAsync(dr);
		}

		[Fact]
		public async Task Schema()
		{
			var dr = TestData.GetTypedData();
			var sw = new StringWriter();
			var csv = new CsvDataWriter(sw);
			await csv.WriteAsync(dr);
		}
	}
}
