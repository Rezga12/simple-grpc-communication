// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/pokergame.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcServer {

  /// <summary>Holder for reflection information generated from Protos/pokergame.proto</summary>
  public static partial class PokergameReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/pokergame.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokergameReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90b3MvcG9rZXJnYW1lLnByb3RvEgVQb2tlciKcAgoJQ2FyZE1vZGVs",
            "EiMKBGtpbmQYASABKA4yFS5Qb2tlci5DYXJkTW9kZWwuS2luZBIlCgV2YWx1",
            "ZRgCIAEoDjIWLlBva2VyLkNhcmRNb2RlbC5WYWx1ZSI3CgRLaW5kEgoKBkhF",
            "QVJUUxAAEgkKBUNMVUJTEAESDAoIRElBTU9ORFMQAhIKCgZTUEFERVMQAyKJ",
            "AQoFVmFsdWUSBwoDQUNFEAASBwoDVFdPEAESCQoFVEhSRUUQAhIICgRGT1VS",
            "EAMSCAoERklWRRAEEgcKA1NJWBAFEgkKBVNFVkVOEAYSCQoFRUlHSFQQBxII",
            "CgROSU5FEAgSBwoDVEVOEAkSCAoESkFDSxAKEgkKBVFVRUVOEAsSCAoES0lO",
            "RxAMIhIKEFJlcXVlc3RIYW5kTW9kZWwiMwoRSGFuZFJlc3BvbnNlTW9kZWwS",
            "HgoEY2FyZBgBIAMoCzIQLlBva2VyLkNhcmRNb2RlbDJOCglQb2tlckdhbWUS",
            "QQoMR2V0UG9rZXJIYW5kEhcuUG9rZXIuUmVxdWVzdEhhbmRNb2RlbBoYLlBv",
            "a2VyLkhhbmRSZXNwb25zZU1vZGVsQg2qAgpHcnBjU2VydmVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.CardModel), global::GrpcServer.CardModel.Parser, new[]{ "Kind", "Value" }, null, new[]{ typeof(global::GrpcServer.CardModel.Types.Kind), typeof(global::GrpcServer.CardModel.Types.Value) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.RequestHandModel), global::GrpcServer.RequestHandModel.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcServer.HandResponseModel), global::GrpcServer.HandResponseModel.Parser, new[]{ "Card" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CardModel : pb::IMessage<CardModel> {
    private static readonly pb::MessageParser<CardModel> _parser = new pb::MessageParser<CardModel>(() => new CardModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.PokergameReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardModel(CardModel other) : this() {
      kind_ = other.kind_;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardModel Clone() {
      return new CardModel(this);
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 1;
    private global::GrpcServer.CardModel.Types.Kind kind_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcServer.CardModel.Types.Kind Kind {
      get { return kind_; }
      set {
        kind_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::GrpcServer.CardModel.Types.Value value_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcServer.CardModel.Types.Value Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Kind != other.Kind) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Kind != 0) hash ^= Kind.GetHashCode();
      if (Value != 0) hash ^= Value.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Kind != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Kind);
      }
      if (Value != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Kind != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Kind);
      }
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardModel other) {
      if (other == null) {
        return;
      }
      if (other.Kind != 0) {
        Kind = other.Kind;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Kind = (global::GrpcServer.CardModel.Types.Kind) input.ReadEnum();
            break;
          }
          case 16: {
            Value = (global::GrpcServer.CardModel.Types.Value) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CardModel message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Kind {
        [pbr::OriginalName("HEARTS")] Hearts = 0,
        [pbr::OriginalName("CLUBS")] Clubs = 1,
        [pbr::OriginalName("DIAMONDS")] Diamonds = 2,
        [pbr::OriginalName("SPADES")] Spades = 3,
      }

      public enum Value {
        [pbr::OriginalName("ACE")] Ace = 0,
        [pbr::OriginalName("TWO")] Two = 1,
        [pbr::OriginalName("THREE")] Three = 2,
        [pbr::OriginalName("FOUR")] Four = 3,
        [pbr::OriginalName("FIVE")] Five = 4,
        [pbr::OriginalName("SIX")] Six = 5,
        [pbr::OriginalName("SEVEN")] Seven = 6,
        [pbr::OriginalName("EIGHT")] Eight = 7,
        [pbr::OriginalName("NINE")] Nine = 8,
        [pbr::OriginalName("TEN")] Ten = 9,
        [pbr::OriginalName("JACK")] Jack = 10,
        [pbr::OriginalName("QUEEN")] Queen = 11,
        [pbr::OriginalName("KING")] King = 12,
      }

    }
    #endregion

  }

  public sealed partial class RequestHandModel : pb::IMessage<RequestHandModel> {
    private static readonly pb::MessageParser<RequestHandModel> _parser = new pb::MessageParser<RequestHandModel>(() => new RequestHandModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestHandModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.PokergameReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestHandModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestHandModel(RequestHandModel other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestHandModel Clone() {
      return new RequestHandModel(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestHandModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestHandModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestHandModel other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class HandResponseModel : pb::IMessage<HandResponseModel> {
    private static readonly pb::MessageParser<HandResponseModel> _parser = new pb::MessageParser<HandResponseModel>(() => new HandResponseModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HandResponseModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcServer.PokergameReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HandResponseModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HandResponseModel(HandResponseModel other) : this() {
      card_ = other.card_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HandResponseModel Clone() {
      return new HandResponseModel(this);
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcServer.CardModel> _repeated_card_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcServer.CardModel.Parser);
    private readonly pbc::RepeatedField<global::GrpcServer.CardModel> card_ = new pbc::RepeatedField<global::GrpcServer.CardModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcServer.CardModel> Card {
      get { return card_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HandResponseModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HandResponseModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!card_.Equals(other.card_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= card_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      card_.WriteTo(output, _repeated_card_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += card_.CalculateSize(_repeated_card_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HandResponseModel other) {
      if (other == null) {
        return;
      }
      card_.Add(other.card_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            card_.AddEntriesFrom(input, _repeated_card_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
