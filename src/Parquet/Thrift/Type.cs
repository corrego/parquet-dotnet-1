#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Parquet.Thrift
{
  /// <summary>
  /// Types supported by Parquet.  These types are intended to be used in combination
  /// with the encodings to control the on disk storage format.
  /// For example INT16 is not included as a type since a good encoding of INT32
  /// would handle this.
  /// </summary>
  public enum Type
  {
    BOOLEAN = 0,
    INT32 = 1,
    INT64 = 2,
    INT96 = 3,
    FLOAT = 4,
    DOUBLE = 5,
    BYTE_ARRAY = 6,
    FIXED_LEN_BYTE_ARRAY = 7,
  }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member