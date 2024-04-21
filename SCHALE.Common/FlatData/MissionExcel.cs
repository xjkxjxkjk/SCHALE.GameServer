// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MissionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MissionExcel GetRootAsMissionExcel(ByteBuffer _bb) { return GetRootAsMissionExcel(_bb, new MissionExcel()); }
  public static MissionExcel GetRootAsMissionExcel(ByteBuffer _bb, MissionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MissionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.MissionCategory Category { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.MissionCategory)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MissionCategory.Challenge; } }
  public string Description { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(8); }
  public SCHALE.Common.FlatData.MissionResetType ResetType { get { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.MissionResetType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MissionResetType.None; } }
  public SCHALE.Common.FlatData.MissionToastDisplayConditionType ToastDisplayType { get { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.MissionToastDisplayConditionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MissionToastDisplayConditionType.Always; } }
  public string ToastImagePath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetToastImagePathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetToastImagePathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetToastImagePathArray() { return __p.__vector_as_array<byte>(14); }
  public bool ViewFlag { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Limit { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string StartDate { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(20); }
  public string EndDate { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(22); }
  public long EndDay { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string StartableEndDate { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartableEndDateBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetStartableEndDateBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetStartableEndDateArray() { return __p.__vector_as_array<byte>(26); }
  public SCHALE.Common.FlatData.ContentType DateAutoRefer { get { int o = __p.__offset(28); return o != 0 ? (SCHALE.Common.FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ContentType.None; } }
  public long DisplayOrder { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreMissionId(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PreMissionIdLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPreMissionIdBytes() { return __p.__vector_as_span<long>(32, 8); }
#else
  public ArraySegment<byte>? GetPreMissionIdBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public long[] GetPreMissionIdArray() { return __p.__vector_as_array<long>(32); }
  public SCHALE.Common.FlatData.AccountState AccountType { get { int o = __p.__offset(34); return o != 0 ? (SCHALE.Common.FlatData.AccountState)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.AccountState.WaitingSignIn; } }
  public long AccountLevel { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.SuddenMissionContentType ContentTags(int j) { int o = __p.__offset(38); return o != 0 ? (SCHALE.Common.FlatData.SuddenMissionContentType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.SuddenMissionContentType)0; }
  public int ContentTagsLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.SuddenMissionContentType> GetContentTagsBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.SuddenMissionContentType>(38, 4); }
#else
  public ArraySegment<byte>? GetContentTagsBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public SCHALE.Common.FlatData.SuddenMissionContentType[] GetContentTagsArray() { int o = __p.__offset(38); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.SuddenMissionContentType[] a = new SCHALE.Common.FlatData.SuddenMissionContentType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.SuddenMissionContentType)__p.bb.GetInt(p + i * 4); } return a; }
  public string ShortcutUI(int j) { int o = __p.__offset(40); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUILength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long ChallengeStageShortcut { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.MissionCompleteConditionType CompleteConditionType { get { int o = __p.__offset(44); return o != 0 ? (SCHALE.Common.FlatData.MissionCompleteConditionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MissionCompleteConditionType.None; } }
  public long CompleteConditionCount { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CompleteConditionParameter(int j) { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionParameterLength { get { int o = __p.__offset(48); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionParameterBytes() { return __p.__vector_as_span<long>(48, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public long[] GetCompleteConditionParameterArray() { return __p.__vector_as_array<long>(48); }
  public SCHALE.Common.FlatData.Tag CompleteConditionParameterTag(int j) { int o = __p.__offset(50); return o != 0 ? (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.Tag)0; }
  public int CompleteConditionParameterTagLength { get { int o = __p.__offset(50); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.Tag> GetCompleteConditionParameterTagBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.Tag>(50, 4); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterTagBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public SCHALE.Common.FlatData.Tag[] GetCompleteConditionParameterTagArray() { int o = __p.__offset(50); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.Tag[] a = new SCHALE.Common.FlatData.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public string RewardIcon { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRewardIconBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetRewardIconBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetRewardIconArray() { return __p.__vector_as_array<byte>(52); }
  public SCHALE.Common.FlatData.ParcelType MissionRewardParcelType(int j) { int o = __p.__offset(54); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int MissionRewardParcelTypeLength { get { int o = __p.__offset(54); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetMissionRewardParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(54, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetMissionRewardParcelTypeArray() { int o = __p.__offset(54); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MissionRewardParcelId(int j) { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MissionRewardParcelIdLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMissionRewardParcelIdBytes() { return __p.__vector_as_span<long>(56, 8); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public long[] GetMissionRewardParcelIdArray() { return __p.__vector_as_array<long>(56); }
  public int MissionRewardAmount(int j) { int o = __p.__offset(58); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MissionRewardAmountLength { get { int o = __p.__offset(58); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMissionRewardAmountBytes() { return __p.__vector_as_span<int>(58, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardAmountBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public int[] GetMissionRewardAmountArray() { return __p.__vector_as_array<int>(58); }

  public static Offset<SCHALE.Common.FlatData.MissionExcel> CreateMissionExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.MissionCategory Category = SCHALE.Common.FlatData.MissionCategory.Challenge,
      StringOffset DescriptionOffset = default(StringOffset),
      SCHALE.Common.FlatData.MissionResetType ResetType = SCHALE.Common.FlatData.MissionResetType.None,
      SCHALE.Common.FlatData.MissionToastDisplayConditionType ToastDisplayType = SCHALE.Common.FlatData.MissionToastDisplayConditionType.Always,
      StringOffset ToastImagePathOffset = default(StringOffset),
      bool ViewFlag = false,
      bool Limit = false,
      StringOffset StartDateOffset = default(StringOffset),
      StringOffset EndDateOffset = default(StringOffset),
      long EndDay = 0,
      StringOffset StartableEndDateOffset = default(StringOffset),
      SCHALE.Common.FlatData.ContentType DateAutoRefer = SCHALE.Common.FlatData.ContentType.None,
      long DisplayOrder = 0,
      VectorOffset PreMissionIdOffset = default(VectorOffset),
      SCHALE.Common.FlatData.AccountState AccountType = SCHALE.Common.FlatData.AccountState.WaitingSignIn,
      long AccountLevel = 0,
      VectorOffset ContentTagsOffset = default(VectorOffset),
      VectorOffset ShortcutUIOffset = default(VectorOffset),
      long ChallengeStageShortcut = 0,
      SCHALE.Common.FlatData.MissionCompleteConditionType CompleteConditionType = SCHALE.Common.FlatData.MissionCompleteConditionType.None,
      long CompleteConditionCount = 0,
      VectorOffset CompleteConditionParameterOffset = default(VectorOffset),
      VectorOffset CompleteConditionParameterTagOffset = default(VectorOffset),
      StringOffset RewardIconOffset = default(StringOffset),
      VectorOffset MissionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset MissionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset MissionRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(28);
    MissionExcel.AddCompleteConditionCount(builder, CompleteConditionCount);
    MissionExcel.AddChallengeStageShortcut(builder, ChallengeStageShortcut);
    MissionExcel.AddAccountLevel(builder, AccountLevel);
    MissionExcel.AddDisplayOrder(builder, DisplayOrder);
    MissionExcel.AddEndDay(builder, EndDay);
    MissionExcel.AddId(builder, Id);
    MissionExcel.AddMissionRewardAmount(builder, MissionRewardAmountOffset);
    MissionExcel.AddMissionRewardParcelId(builder, MissionRewardParcelIdOffset);
    MissionExcel.AddMissionRewardParcelType(builder, MissionRewardParcelTypeOffset);
    MissionExcel.AddRewardIcon(builder, RewardIconOffset);
    MissionExcel.AddCompleteConditionParameterTag(builder, CompleteConditionParameterTagOffset);
    MissionExcel.AddCompleteConditionParameter(builder, CompleteConditionParameterOffset);
    MissionExcel.AddCompleteConditionType(builder, CompleteConditionType);
    MissionExcel.AddShortcutUI(builder, ShortcutUIOffset);
    MissionExcel.AddContentTags(builder, ContentTagsOffset);
    MissionExcel.AddAccountType(builder, AccountType);
    MissionExcel.AddPreMissionId(builder, PreMissionIdOffset);
    MissionExcel.AddDateAutoRefer(builder, DateAutoRefer);
    MissionExcel.AddStartableEndDate(builder, StartableEndDateOffset);
    MissionExcel.AddEndDate(builder, EndDateOffset);
    MissionExcel.AddStartDate(builder, StartDateOffset);
    MissionExcel.AddToastImagePath(builder, ToastImagePathOffset);
    MissionExcel.AddToastDisplayType(builder, ToastDisplayType);
    MissionExcel.AddResetType(builder, ResetType);
    MissionExcel.AddDescription(builder, DescriptionOffset);
    MissionExcel.AddCategory(builder, Category);
    MissionExcel.AddLimit(builder, Limit);
    MissionExcel.AddViewFlag(builder, ViewFlag);
    return MissionExcel.EndMissionExcel(builder);
  }

  public static void StartMissionExcel(FlatBufferBuilder builder) { builder.StartTable(28); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddCategory(FlatBufferBuilder builder, SCHALE.Common.FlatData.MissionCategory category) { builder.AddInt(1, (int)category, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(2, descriptionOffset.Value, 0); }
  public static void AddResetType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MissionResetType resetType) { builder.AddInt(3, (int)resetType, 0); }
  public static void AddToastDisplayType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MissionToastDisplayConditionType toastDisplayType) { builder.AddInt(4, (int)toastDisplayType, 0); }
  public static void AddToastImagePath(FlatBufferBuilder builder, StringOffset toastImagePathOffset) { builder.AddOffset(5, toastImagePathOffset.Value, 0); }
  public static void AddViewFlag(FlatBufferBuilder builder, bool viewFlag) { builder.AddBool(6, viewFlag, false); }
  public static void AddLimit(FlatBufferBuilder builder, bool limit) { builder.AddBool(7, limit, false); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset startDateOffset) { builder.AddOffset(8, startDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset endDateOffset) { builder.AddOffset(9, endDateOffset.Value, 0); }
  public static void AddEndDay(FlatBufferBuilder builder, long endDay) { builder.AddLong(10, endDay, 0); }
  public static void AddStartableEndDate(FlatBufferBuilder builder, StringOffset startableEndDateOffset) { builder.AddOffset(11, startableEndDateOffset.Value, 0); }
  public static void AddDateAutoRefer(FlatBufferBuilder builder, SCHALE.Common.FlatData.ContentType dateAutoRefer) { builder.AddInt(12, (int)dateAutoRefer, 0); }
  public static void AddDisplayOrder(FlatBufferBuilder builder, long displayOrder) { builder.AddLong(13, displayOrder, 0); }
  public static void AddPreMissionId(FlatBufferBuilder builder, VectorOffset preMissionIdOffset) { builder.AddOffset(14, preMissionIdOffset.Value, 0); }
  public static VectorOffset CreatePreMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAccountType(FlatBufferBuilder builder, SCHALE.Common.FlatData.AccountState accountType) { builder.AddInt(15, (int)accountType, 0); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long accountLevel) { builder.AddLong(16, accountLevel, 0); }
  public static void AddContentTags(FlatBufferBuilder builder, VectorOffset contentTagsOffset) { builder.AddOffset(17, contentTagsOffset.Value, 0); }
  public static VectorOffset CreateContentTagsVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.SuddenMissionContentType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateContentTagsVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.SuddenMissionContentType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateContentTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.SuddenMissionContentType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateContentTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.SuddenMissionContentType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartContentTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutUI(FlatBufferBuilder builder, VectorOffset shortcutUIOffset) { builder.AddOffset(18, shortcutUIOffset.Value, 0); }
  public static VectorOffset CreateShortcutUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChallengeStageShortcut(FlatBufferBuilder builder, long challengeStageShortcut) { builder.AddLong(19, challengeStageShortcut, 0); }
  public static void AddCompleteConditionType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MissionCompleteConditionType completeConditionType) { builder.AddInt(20, (int)completeConditionType, 0); }
  public static void AddCompleteConditionCount(FlatBufferBuilder builder, long completeConditionCount) { builder.AddLong(21, completeConditionCount, 0); }
  public static void AddCompleteConditionParameter(FlatBufferBuilder builder, VectorOffset completeConditionParameterOffset) { builder.AddOffset(22, completeConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionParameterTag(FlatBufferBuilder builder, VectorOffset completeConditionParameterTagOffset) { builder.AddOffset(23, completeConditionParameterTagOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterTagVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterTagVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardIcon(FlatBufferBuilder builder, StringOffset rewardIconOffset) { builder.AddOffset(24, rewardIconOffset.Value, 0); }
  public static void AddMissionRewardParcelType(FlatBufferBuilder builder, VectorOffset missionRewardParcelTypeOffset) { builder.AddOffset(25, missionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionRewardParcelId(FlatBufferBuilder builder, VectorOffset missionRewardParcelIdOffset) { builder.AddOffset(26, missionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMissionRewardAmount(FlatBufferBuilder builder, VectorOffset missionRewardAmountOffset) { builder.AddOffset(27, missionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.MissionExcel> EndMissionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MissionExcel>(o);
  }
}


static public class MissionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Category*/, 4 /*SCHALE.Common.FlatData.MissionCategory*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Description*/, false)
      && verifier.VerifyField(tablePos, 10 /*ResetType*/, 4 /*SCHALE.Common.FlatData.MissionResetType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ToastDisplayType*/, 4 /*SCHALE.Common.FlatData.MissionToastDisplayConditionType*/, 4, false)
      && verifier.VerifyString(tablePos, 14 /*ToastImagePath*/, false)
      && verifier.VerifyField(tablePos, 16 /*ViewFlag*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 18 /*Limit*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 20 /*StartDate*/, false)
      && verifier.VerifyString(tablePos, 22 /*EndDate*/, false)
      && verifier.VerifyField(tablePos, 24 /*EndDay*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 26 /*StartableEndDate*/, false)
      && verifier.VerifyField(tablePos, 28 /*DateAutoRefer*/, 4 /*SCHALE.Common.FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*DisplayOrder*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*PreMissionId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 34 /*AccountType*/, 4 /*SCHALE.Common.FlatData.AccountState*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*AccountLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*ContentTags*/, 4 /*SCHALE.Common.FlatData.SuddenMissionContentType*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 40 /*ShortcutUI*/, false)
      && verifier.VerifyField(tablePos, 42 /*ChallengeStageShortcut*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*CompleteConditionType*/, 4 /*SCHALE.Common.FlatData.MissionCompleteConditionType*/, 4, false)
      && verifier.VerifyField(tablePos, 46 /*CompleteConditionCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 48 /*CompleteConditionParameter*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 50 /*CompleteConditionParameterTag*/, 4 /*SCHALE.Common.FlatData.Tag*/, false)
      && verifier.VerifyString(tablePos, 52 /*RewardIcon*/, false)
      && verifier.VerifyVectorOfData(tablePos, 54 /*MissionRewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 56 /*MissionRewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 58 /*MissionRewardAmount*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}