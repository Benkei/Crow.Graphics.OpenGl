﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 14.0.0.0
//  
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code neu generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Crow.Vulkan.SpecGen
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class StructTemplete : StructTempleteBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            return this.GenerationEnvironment.ToString();
        }
        
        #line 5 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

protected void WriteStruct(SpecStruct info)
{
	if(info.TypeHandle || info.TypeHandle64)
	{
		WriteStructHandle (info);
		return;
	}

        
        #line default
        #line hidden
        
        #line 13 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("// ");

        
        #line default
        #line hidden
        
        #line 14 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.Name));

        
        #line default
        #line hidden
        
        #line 14 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 15 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

	if(info.Members.Count > 1)
	{

        
        #line default
        #line hidden
        
        #line 18 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("[StructLayout (");

        
        #line default
        #line hidden
        
        #line 19 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.Union ? "LayoutKind.Explicit" : "LayoutKind.Sequential"));

        
        #line default
        #line hidden
        
        #line 19 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(")]\r\n");

        
        #line default
        #line hidden
        
        #line 20 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

	}

        
        #line default
        #line hidden
        
        #line 22 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("public unsafe partial struct ");

        
        #line default
        #line hidden
        
        #line 23 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 23 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\r\n{\r\n");

        
        #line default
        #line hidden
        
        #line 25 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

	foreach(var item in info.Members)
	{

        
        #line default
        #line hidden
        
        #line 28 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\t// ");

        
        #line default
        #line hidden
        
        #line 29 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(item.DebugLog()));

        
        #line default
        #line hidden
        
        #line 29 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 30 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

		if(info.Members.Count > 1 && info.Union)
		{

        
        #line default
        #line hidden
        
        #line 33 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\t[FieldOffset (0)]\r\n");

        
        #line default
        #line hidden
        
        #line 35 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

		}
		if(item.FixedSize == 0 && item.FixedSizeEnum == null)
		{

        
        #line default
        #line hidden
        
        #line 39 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\tpublic ");

        
        #line default
        #line hidden
        
        #line 40 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeMap(item)));

        
        #line default
        #line hidden
        
        #line 40 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 40 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(item.MapName));

        
        #line default
        #line hidden
        
        #line 40 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 41 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

		}
		else
		{

        
        #line default
        #line hidden
        
        #line 45 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\tpublic fixed ");

        
        #line default
        #line hidden
        
        #line 46 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeMap(item)));

        
        #line default
        #line hidden
        
        #line 46 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 46 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(item.MapName));

        
        #line default
        #line hidden
        
        #line 46 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("[");

        
        #line default
        #line hidden
        
        #line 46 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(item.FixedSize));

        
        #line default
        #line hidden
        
        #line 46 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("];\r\n");

        
        #line default
        #line hidden
        
        #line 47 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

		}
	}

        
        #line default
        #line hidden
        
        #line 50 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("}\r\n");

        
        #line default
        #line hidden
        
        #line 52 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

}

protected string GetTypeMap(SpecField field)
{
	if ( field.MapType != null )
		return field.MapType;

	string result = null;
	string type;
	if ( !string.IsNullOrEmpty(field.Attribute) )
	{
		result += field.Attribute + " ";
	}
	if ( string.Equals ( field.Type.Name, "void", StringComparison.InvariantCultureIgnoreCase ) )
	{
		type = "IntPtr";
		result += "IntPtr";
	}
	else
	{
		type = field.Type.FinalTypeName();
		if ( field.IsPointer && !(field.Attribute != null && (field.Attribute.Contains("out") || field.Attribute.Contains("ref"))) )
		{
			type += "*";
		}
		result += type;
	}
	return result;
}

protected void WriteStructHandle(SpecStruct info)
{
	string type = info.TypeHandle ? "IntPtr" : "ulong";
	string typeEmpty = info.TypeHandle ? "IntPtr.Zero" : "0";

        
        #line default
        #line hidden
        
        #line 87 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("// ");

        
        #line default
        #line hidden
        
        #line 88 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.Name));

        
        #line default
        #line hidden
        
        #line 88 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("\r\n[DebuggerDisplay ( \"{ToString()}\" )]\r\npublic unsafe partial struct ");

        
        #line default
        #line hidden
        
        #line 90 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 90 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" : IEquatable<");

        
        #line default
        #line hidden
        
        #line 90 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 90 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(">\r\n{\r\n\tprivate ");

        
        #line default
        #line hidden
        
        #line 92 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(type));

        
        #line default
        #line hidden
        
        #line 92 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" handle;\r\n\r\n\tpublic static readonly ");

        
        #line default
        #line hidden
        
        #line 94 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 94 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" Zero;\r\n\r\n\tpublic ");

        
        #line default
        #line hidden
        
        #line 96 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 96 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 96 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(type));

        
        #line default
        #line hidden
        
        #line 96 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value)\r\n\t{\r\n\t\thandle = value;\r\n\t}\r\n\r\n\tpublic bool IsZero { get { return handle =" +
        "= ");

        
        #line default
        #line hidden
        
        #line 101 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(typeEmpty));

        
        #line default
        #line hidden
        
        #line 101 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("; } }\r\n\t\r\n\tpublic bool Equals(");

        
        #line default
        #line hidden
        
        #line 103 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 103 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" other)\r\n\t{\r\n\t\treturn other.handle == handle;\r\n\t}\r\n\tpublic override bool Equals(o" +
        "bject obj)\r\n\t{\r\n\t\treturn obj is ");

        
        #line default
        #line hidden
        
        #line 109 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 109 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" && ((");

        
        #line default
        #line hidden
        
        #line 109 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 109 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(")obj).handle == handle;\r\n\t}\r\n\tpublic override int GetHashCode()\r\n\t{\r\n\t\treturn han" +
        "dle.GetHashCode ();\r\n\t}\r\n\tpublic override string ToString()\r\n\t{\r\n\t\treturn handle" +
        ".ToString (");

        
        #line default
        #line hidden
        
        #line 117 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.TypeHandle ? "" : "CultureInfo.InvariantCulture"));

        
        #line default
        #line hidden
        
        #line 117 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(");\r\n\t}\r\n\t\r\n\tpublic static bool operator ==(");

        
        #line default
        #line hidden
        
        #line 120 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 120 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value1, ");

        
        #line default
        #line hidden
        
        #line 120 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 120 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value2)\r\n\t{\r\n\t\treturn value1.handle == value2.handle;\r\n\t}\r\n\tpublic static bool o" +
        "perator !=(");

        
        #line default
        #line hidden
        
        #line 124 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 124 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value1, ");

        
        #line default
        #line hidden
        
        #line 124 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 124 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value2)\r\n\t{\r\n\t\treturn value1.handle != value2.handle;\r\n\t}\r\n\tpublic static explic" +
        "it operator ");

        
        #line default
        #line hidden
        
        #line 128 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(type));

        
        #line default
        #line hidden
        
        #line 128 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 128 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 128 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value)\r\n\t{\r\n\t\treturn value.handle;\r\n\t}\r\n\tpublic static explicit operator ");

        
        #line default
        #line hidden
        
        #line 132 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 132 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 132 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(type));

        
        #line default
        #line hidden
        
        #line 132 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" value)\r\n\t{\r\n\t\treturn new ");

        
        #line default
        #line hidden
        
        #line 134 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(info.MapName));

        
        #line default
        #line hidden
        
        #line 134 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"
this.Write(" (value);\r\n\t}\r\n}\r\n");

        
        #line default
        #line hidden
        
        #line 137 "F:\Projects\Crow.Graphics.OpenGl\Crow.Graphics.Vulkan.SpecGen\StructTemplete.tt"

}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class StructTempleteBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
