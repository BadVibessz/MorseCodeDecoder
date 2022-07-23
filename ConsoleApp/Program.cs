using MorseCodeDecoderLibrary;

var morseCode = ".... . .-.. .-.. --- .-- --- .-. .-.. -..";
var decoded = MorseDecoder.DecodeFromMorse(morseCode);
var encoded = MorseDecoder.EncodeToMorse(decoded);

Console.WriteLine(decoded);
Console.WriteLine(encoded);

Console.WriteLine(morseCode == encoded);