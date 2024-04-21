// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentMeetupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentMeetupExcel GetRootAsEventContentMeetupExcel(ByteBuffer _bb) { return GetRootAsEventContentMeetupExcel(_bb, new EventContentMeetupExcel()); }
  public static EventContentMeetupExcel GetRootAsEventContentMeetupExcel(ByteBuffer _bb, EventContentMeetupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentMeetupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConditionScenarioGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.MeetupConditionType ConditionType { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.MeetupConditionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MeetupConditionType.None; } }
  public long ConditionParameter(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionParameterLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionParameterBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetConditionParameterBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetConditionParameterArray() { return __p.__vector_as_array<long>(14); }
  public SCHALE.Common.FlatData.MeetupConditionPrintType ConditionPrintType { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.MeetupConditionPrintType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MeetupConditionPrintType.None; } }

  public static Offset<SCHALE.Common.FlatData.EventContentMeetupExcel> CreateEventContentMeetupExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long CharacterId = 0,
      long ConditionScenarioGroupId = 0,
      SCHALE.Common.FlatData.MeetupConditionType ConditionType = SCHALE.Common.FlatData.MeetupConditionType.None,
      VectorOffset ConditionParameterOffset = default(VectorOffset),
      SCHALE.Common.FlatData.MeetupConditionPrintType ConditionPrintType = SCHALE.Common.FlatData.MeetupConditionPrintType.None) {
    builder.StartTable(7);
    EventContentMeetupExcel.AddConditionScenarioGroupId(builder, ConditionScenarioGroupId);
    EventContentMeetupExcel.AddCharacterId(builder, CharacterId);
    EventContentMeetupExcel.AddEventContentId(builder, EventContentId);
    EventContentMeetupExcel.AddId(builder, Id);
    EventContentMeetupExcel.AddConditionPrintType(builder, ConditionPrintType);
    EventContentMeetupExcel.AddConditionParameter(builder, ConditionParameterOffset);
    EventContentMeetupExcel.AddConditionType(builder, ConditionType);
    return EventContentMeetupExcel.EndEventContentMeetupExcel(builder);
  }

  public static void StartEventContentMeetupExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(2, characterId, 0); }
  public static void AddConditionScenarioGroupId(FlatBufferBuilder builder, long conditionScenarioGroupId) { builder.AddLong(3, conditionScenarioGroupId, 0); }
  public static void AddConditionType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MeetupConditionType conditionType) { builder.AddInt(4, (int)conditionType, 0); }
  public static void AddConditionParameter(FlatBufferBuilder builder, VectorOffset conditionParameterOffset) { builder.AddOffset(5, conditionParameterOffset.Value, 0); }
  public static VectorOffset CreateConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConditionPrintType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MeetupConditionPrintType conditionPrintType) { builder.AddInt(6, (int)conditionPrintType, 0); }
  public static Offset<SCHALE.Common.FlatData.EventContentMeetupExcel> EndEventContentMeetupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentMeetupExcel>(o);
  }
}


static public class EventContentMeetupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*ConditionScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ConditionType*/, 4 /*SCHALE.Common.FlatData.MeetupConditionType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*ConditionParameter*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 16 /*ConditionPrintType*/, 4 /*SCHALE.Common.FlatData.MeetupConditionPrintType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}