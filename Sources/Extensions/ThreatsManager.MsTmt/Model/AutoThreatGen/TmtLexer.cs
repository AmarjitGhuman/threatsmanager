//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Tmt.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ThreatsManager.MsTmt.Model.AutoThreatGen {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class TmtLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		PROPERTY=1, FLOW=2, SOURCE=3, TARGET=4, IS=5, CROSSES=6, AND=7, OR=8, 
		NOT=9, LPAREN=10, RPAREN=11, CHARACTER=12, CHARACTER_POINT=13, TEXT=14, 
		WHITESPACE=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PROPERTY", "UPPERLETTER", "LOWERLETTER", "DIGIT", "FLOW", "SOURCE", "TARGET", 
		"IS", "CROSSES", "AND", "OR", "NOT", "LPAREN", "RPAREN", "CHARACTER", 
		"CHARACTER_POINT", "TEXT", "WHITESPACE"
	};


	public TmtLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TmtLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'flow'", "'source'", "'target'", "'is'", "'crosses'", "'and'", 
		"'or'", "'not'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PROPERTY", "FLOW", "SOURCE", "TARGET", "IS", "CROSSES", "AND", 
		"OR", "NOT", "LPAREN", "RPAREN", "CHARACTER", "CHARACTER_POINT", "TEXT", 
		"WHITESPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Tmt.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TmtLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x11', 'z', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x3', '\x2', '\x3', '\x2', '\x6', '\x2', '*', '\n', '\x2', '\r', 
		'\x2', '\xE', '\x2', '+', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x5', '\x10', '\x65', '\n', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x5', '\x11', 'i', '\n', '\x11', 
		'\x3', '\x12', '\x3', '\x12', '\a', '\x12', 'm', '\n', '\x12', '\f', '\x12', 
		'\xE', '\x12', 'p', '\v', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x13', '\x6', '\x13', 'u', '\n', '\x13', '\r', '\x13', '\xE', '\x13', 
		'v', '\x3', '\x13', '\x3', '\x13', '\x2', '\x2', '\x14', '\x3', '\x3', 
		'\x5', '\x2', '\a', '\x2', '\t', '\x2', '\v', '\x4', '\r', '\x5', '\xF', 
		'\x6', '\x11', '\a', '\x13', '\b', '\x15', '\t', '\x17', '\n', '\x19', 
		'\v', '\x1B', '\f', '\x1D', '\r', '\x1F', '\xE', '!', '\xF', '#', '\x10', 
		'%', '\x11', '\x3', '\x2', '\a', '\x3', '\x2', '\x43', '\\', '\x3', '\x2', 
		'\x63', '|', '\x3', '\x2', '\x32', ';', '\x3', '\x2', ')', ')', '\x4', 
		'\x2', '\v', '\v', '\"', '\"', '\x2', '}', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\'', '\x3', '\x2', '\x2', '\x2', '\x5', '-', 
		'\x3', '\x2', '\x2', '\x2', '\a', '/', '\x3', '\x2', '\x2', '\x2', '\t', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\v', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x38', '\x3', '\x2', '\x2', '\x2', '\xF', '?', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x46', '\x3', '\x2', '\x2', '\x2', '\x13', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\x15', 'Q', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'U', '\x3', '\x2', '\x2', '\x2', '\x19', 'X', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\\', '\x3', '\x2', '\x2', '\x2', '\x1D', '^', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', '\x64', '\x3', '\x2', '\x2', '\x2', '!', 'h', '\x3', '\x2', 
		'\x2', '\x2', '#', 'j', '\x3', '\x2', '\x2', '\x2', '%', 't', '\x3', '\x2', 
		'\x2', '\x2', '\'', ')', '\a', '\x30', '\x2', '\x2', '(', '*', '\x5', 
		'!', '\x11', '\x2', ')', '(', '\x3', '\x2', '\x2', '\x2', '*', '+', '\x3', 
		'\x2', '\x2', '\x2', '+', ')', '\x3', '\x2', '\x2', '\x2', '+', ',', '\x3', 
		'\x2', '\x2', '\x2', ',', '\x4', '\x3', '\x2', '\x2', '\x2', '-', '.', 
		'\t', '\x2', '\x2', '\x2', '.', '\x6', '\x3', '\x2', '\x2', '\x2', '/', 
		'\x30', '\t', '\x3', '\x2', '\x2', '\x30', '\b', '\x3', '\x2', '\x2', 
		'\x2', '\x31', '\x32', '\t', '\x4', '\x2', '\x2', '\x32', '\n', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x34', '\a', 'h', '\x2', '\x2', '\x34', 
		'\x35', '\a', 'n', '\x2', '\x2', '\x35', '\x36', '\a', 'q', '\x2', '\x2', 
		'\x36', '\x37', '\a', 'y', '\x2', '\x2', '\x37', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x38', '\x39', '\a', 'u', '\x2', '\x2', '\x39', ':', '\a', 'q', 
		'\x2', '\x2', ':', ';', '\a', 'w', '\x2', '\x2', ';', '<', '\a', 't', 
		'\x2', '\x2', '<', '=', '\a', '\x65', '\x2', '\x2', '=', '>', '\a', 'g', 
		'\x2', '\x2', '>', '\xE', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', 
		'v', '\x2', '\x2', '@', '\x41', '\a', '\x63', '\x2', '\x2', '\x41', '\x42', 
		'\a', 't', '\x2', '\x2', '\x42', '\x43', '\a', 'i', '\x2', '\x2', '\x43', 
		'\x44', '\a', 'g', '\x2', '\x2', '\x44', '\x45', '\a', 'v', '\x2', '\x2', 
		'\x45', '\x10', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\a', 'k', '\x2', 
		'\x2', 'G', 'H', '\a', 'u', '\x2', '\x2', 'H', '\x12', '\x3', '\x2', '\x2', 
		'\x2', 'I', 'J', '\a', '\x65', '\x2', '\x2', 'J', 'K', '\a', 't', '\x2', 
		'\x2', 'K', 'L', '\a', 'q', '\x2', '\x2', 'L', 'M', '\a', 'u', '\x2', 
		'\x2', 'M', 'N', '\a', 'u', '\x2', '\x2', 'N', 'O', '\a', 'g', '\x2', 
		'\x2', 'O', 'P', '\a', 'u', '\x2', '\x2', 'P', '\x14', '\x3', '\x2', '\x2', 
		'\x2', 'Q', 'R', '\a', '\x63', '\x2', '\x2', 'R', 'S', '\a', 'p', '\x2', 
		'\x2', 'S', 'T', '\a', '\x66', '\x2', '\x2', 'T', '\x16', '\x3', '\x2', 
		'\x2', '\x2', 'U', 'V', '\a', 'q', '\x2', '\x2', 'V', 'W', '\a', 't', 
		'\x2', '\x2', 'W', '\x18', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', 
		'p', '\x2', '\x2', 'Y', 'Z', '\a', 'q', '\x2', '\x2', 'Z', '[', '\a', 
		'v', '\x2', '\x2', '[', '\x1A', '\x3', '\x2', '\x2', '\x2', '\\', ']', 
		'\a', '*', '\x2', '\x2', ']', '\x1C', '\x3', '\x2', '\x2', '\x2', '^', 
		'_', '\a', '+', '\x2', '\x2', '_', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'`', '\x65', '\x5', '\x5', '\x3', '\x2', '\x61', '\x65', '\x5', '\a', 
		'\x4', '\x2', '\x62', '\x65', '\x5', '\t', '\x5', '\x2', '\x63', '\x65', 
		'\a', '/', '\x2', '\x2', '\x64', '`', '\x3', '\x2', '\x2', '\x2', '\x64', 
		'\x61', '\x3', '\x2', '\x2', '\x2', '\x64', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '\x64', '\x63', '\x3', '\x2', '\x2', '\x2', '\x65', ' ', '\x3', 
		'\x2', '\x2', '\x2', '\x66', 'i', '\x5', '\x1F', '\x10', '\x2', 'g', 'i', 
		'\a', '\x30', '\x2', '\x2', 'h', '\x66', '\x3', '\x2', '\x2', '\x2', 'h', 
		'g', '\x3', '\x2', '\x2', '\x2', 'i', '\"', '\x3', '\x2', '\x2', '\x2', 
		'j', 'n', '\a', ')', '\x2', '\x2', 'k', 'm', '\n', '\x5', '\x2', '\x2', 
		'l', 'k', '\x3', '\x2', '\x2', '\x2', 'm', 'p', '\x3', '\x2', '\x2', '\x2', 
		'n', 'l', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\x3', '\x2', '\x2', '\x2', 
		'o', 'q', '\x3', '\x2', '\x2', '\x2', 'p', 'n', '\x3', '\x2', '\x2', '\x2', 
		'q', 'r', '\a', ')', '\x2', '\x2', 'r', '$', '\x3', '\x2', '\x2', '\x2', 
		's', 'u', '\t', '\x6', '\x2', '\x2', 't', 's', '\x3', '\x2', '\x2', '\x2', 
		'u', 'v', '\x3', '\x2', '\x2', '\x2', 'v', 't', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\b', '\x13', '\x2', '\x2', 'y', '&', '\x3', '\x2', '\x2', '\x2', 
		'\b', '\x2', '+', '\x64', 'h', 'n', 'v', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace ThreatsManager.MsTmt.Model.AutoThreatGen
