using System;
using System.IO;
using System.Text;

namespace CodeGenerator
{
	public class PostFix
	{
		/// <summary>
		/// The path of the file that the PostFix targets.
		/// </summary>
		private string _filePath;

		/// <summary>
		/// The content of the file that the PostFix targets.
		/// </summary>
		private string _fileContent;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="outputPath">The folder of the file that the PostFix targets.</param>
		/// <param name="fileName">The name of the file that the PostFix targets.</param>
		public PostFix(string outputPath, string fileName)
		{
			if (string.IsNullOrEmpty(outputPath))
			{
				throw new InvalidOperationException("The static string `Postfix.OutputPath` must be set before creating a postfix.");
			}

			if (string.IsNullOrEmpty(fileName))
			{
				throw new ArgumentException("String must have non-zero length.", nameof(fileName));
			}

			_filePath = Path.Combine(outputPath, fileName);
			_fileContent = File.ReadAllText(_filePath);

		}

		/// <summary>
		/// Remove lines that include a specified string.
		/// </summary>
		/// <param name="searchValue">The string to search in the source string.</param>
		/// <param name="skipLines">The number of lines to skip. Default: 1</param>
		/// <returns>The string with all lines removed.</returns>
		public PostFix Remove(string searchTerm, int skipLines = 1)
		{
			string line;
			int skipLinesRemaining = 0;

			StringReader sr = new StringReader(_fileContent);
			StringBuilder sb = new StringBuilder();

			while ((line = sr.ReadLine()) != null)
			{
				// Set number of lines to skip (if any)
				if (line.Contains(searchTerm))
				{
					skipLinesRemaining = skipLines;
				}

				// Continue to reading the next line
				if (skipLinesRemaining > 0)
				{
					skipLinesRemaining--;
					continue;
				}

				// No longer skipping, adding all remaining lines
				sb.AppendLine(line);

			}

			// Update content
			_fileContent = sb.ToString();

			return this;

		}

		/// <summary>
		/// Replace a specified string with another specified string.
		/// </summary>
		/// <param name="oldValue">The string to be replaced.</param>
		/// <param name="newValue">The string to replace all occurrences of oldValue.</param>
		/// <returns>The PostFix instance.</returns>
		public PostFix Replace(string oldValue, string newValue)
		{
			_fileContent = _fileContent.Replace(oldValue, newValue);
			return this;

		}

		/// <summary>
		/// Write the changes back to the source file.
		/// </summary>
		/// <returns>The PostFix instance.</returns>
		public PostFix Apply()
		{
			File.WriteAllText(_filePath, _fileContent);
			return this;

		}

	}

	public class PostFixes
	{
		public static void Apply(string outputPath, string libraryName)
		{
			if(libraryName == ImGuiLibraries.ImGui)
			{
				// Invalid default value for local variables, method
				// `CodeGenerator.Program.CorrectDefaultValue` seems
				// like a good place to fix this eventually?
				new PostFix(outputPath, "ImGui.gen.cs")
					.Replace("IntPtr callback = null", "IntPtr callback = IntPtr.Zero")                 // In InputTextEx()
					.Replace("IntPtr custom_callback = null", "IntPtr custom_callback = IntPtr.Zero")   // In SetNextWindowSizeConstraints()
					.Apply();

				new PostFix(outputPath, "ImGuiContext.gen.cs")
					.Remove("ImChunkStream")        // Error CS0208
					.Remove("ImGuiItemFlagsPtr")    // Struct is not being generated at all
					.Remove("NativePtr->Tables")    // Error CS1503 Can not convert from ImPool to ImSpan
					.Remove("NativePtr->TabBars")   // Error CS1503 Can not convert from ImPool to ImSpan
					.Apply();

				new PostFix(outputPath, "ImGuiInputTextState.gen.cs")
					.Remove("ImGuiInputTextCallback UserCallback")  // Different errors. The ImGuiInputTextCallback seems to be handcoded
					.Apply();

				new PostFix(outputPath, "ImGuiDockNode.gen.cs")
					.Replace("RangeAccessor<ImGuiDockNode*>", "RangeAccessor<ImGuiDockNode>")   // Error CS0306 Pointer can't be used as generic argument?
					.Apply();

				new PostFix(outputPath, "ImGuiViewportP.gen.cs")
					.Replace("RangeAccessor<ImDrawList*>", "RangeAccessor<ImDrawList>")   // Error CS0306 Pointer can't be used as generic argument?
					.Apply();
			}

		}

		internal struct ImGuiLibraries
		{
			public static string ImGui = "cimgui";
			public static string ImPlot = "cimplot";
			public static string ImNodes = "cimnodes";
			public static string ImGuizmo = "cimguizmo";
		}

	}
}