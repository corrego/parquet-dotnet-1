#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Transport;

namespace Parquet.Thrift
{

  public partial class ColumnChunk : TBase
  {
    private string _file_path;
    private ColumnMetaData _meta_data;
    private long _offset_index_offset;
    private int _offset_index_length;
    private long _column_index_offset;
    private int _column_index_length;
    private ColumnCryptoMetaData _crypto_metadata;
    private byte[] _encrypted_column_metadata;

    /// <summary>
    /// File where column data is stored.  If not set, assumed to be same file as
    /// metadata.  This path is relative to the current file.
    /// 
    /// </summary>
    public string File_path
    {
      get
      {
        return _file_path;
      }
      set
      {
        __isset.file_path = true;
        this._file_path = value;
      }
    }

    /// <summary>
    /// Byte offset in file_path to the ColumnMetaData *
    /// </summary>
    public long File_offset { get; set; }

    /// <summary>
    /// Column metadata for this chunk. This is the same content as what is at
    /// file_path/file_offset.  Having it here has it replicated in the file
    /// metadata.
    /// 
    /// </summary>
    public ColumnMetaData Meta_data
    {
      get
      {
        return _meta_data;
      }
      set
      {
        __isset.meta_data = true;
        this._meta_data = value;
      }
    }

    /// <summary>
    /// File offset of ColumnChunk's OffsetIndex *
    /// </summary>
    public long Offset_index_offset
    {
      get
      {
        return _offset_index_offset;
      }
      set
      {
        __isset.offset_index_offset = true;
        this._offset_index_offset = value;
      }
    }

    /// <summary>
    /// Size of ColumnChunk's OffsetIndex, in bytes *
    /// </summary>
    public int Offset_index_length
    {
      get
      {
        return _offset_index_length;
      }
      set
      {
        __isset.offset_index_length = true;
        this._offset_index_length = value;
      }
    }

    /// <summary>
    /// File offset of ColumnChunk's ColumnIndex *
    /// </summary>
    public long Column_index_offset
    {
      get
      {
        return _column_index_offset;
      }
      set
      {
        __isset.column_index_offset = true;
        this._column_index_offset = value;
      }
    }

    /// <summary>
    /// Size of ColumnChunk's ColumnIndex, in bytes *
    /// </summary>
    public int Column_index_length
    {
      get
      {
        return _column_index_length;
      }
      set
      {
        __isset.column_index_length = true;
        this._column_index_length = value;
      }
    }

    /// <summary>
    /// Crypto metadata of encrypted columns *
    /// </summary>
    public ColumnCryptoMetaData Crypto_metadata
    {
      get
      {
        return _crypto_metadata;
      }
      set
      {
        __isset.crypto_metadata = true;
        this._crypto_metadata = value;
      }
    }

    /// <summary>
    /// Encrypted column metadata for this chunk *
    /// </summary>
    public byte[] Encrypted_column_metadata
    {
      get
      {
        return _encrypted_column_metadata;
      }
      set
      {
        __isset.encrypted_column_metadata = true;
        this._encrypted_column_metadata = value;
      }
    }


    public Isset __isset;
    public struct Isset {
      public bool file_path;
      public bool meta_data;
      public bool offset_index_offset;
      public bool offset_index_length;
      public bool column_index_offset;
      public bool column_index_length;
      public bool crypto_metadata;
      public bool encrypted_column_metadata;
    }

    public ColumnChunk() {
    }

    public ColumnChunk(long file_offset) : this() {
      this.File_offset = file_offset;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_file_offset = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                File_path = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I64) {
                File_offset = iprot.ReadI64();
                isset_file_offset = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                Meta_data = new ColumnMetaData();
                Meta_data.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I64) {
                Offset_index_offset = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I32) {
                Offset_index_length = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I64) {
                Column_index_offset = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I32) {
                Column_index_length = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Struct) {
                Crypto_metadata = new ColumnCryptoMetaData();
                Crypto_metadata.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.String) {
                Encrypted_column_metadata = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_file_offset)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("ColumnChunk");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (File_path != null && __isset.file_path) {
          field.Name = "file_path";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(File_path);
          oprot.WriteFieldEnd();
        }
        field.Name = "file_offset";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(File_offset);
        oprot.WriteFieldEnd();
        if (Meta_data != null && __isset.meta_data) {
          field.Name = "meta_data";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          Meta_data.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.offset_index_offset) {
          field.Name = "offset_index_offset";
          field.Type = TType.I64;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Offset_index_offset);
          oprot.WriteFieldEnd();
        }
        if (__isset.offset_index_length) {
          field.Name = "offset_index_length";
          field.Type = TType.I32;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Offset_index_length);
          oprot.WriteFieldEnd();
        }
        if (__isset.column_index_offset) {
          field.Name = "column_index_offset";
          field.Type = TType.I64;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Column_index_offset);
          oprot.WriteFieldEnd();
        }
        if (__isset.column_index_length) {
          field.Name = "column_index_length";
          field.Type = TType.I32;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Column_index_length);
          oprot.WriteFieldEnd();
        }
        if (Crypto_metadata != null && __isset.crypto_metadata) {
          field.Name = "crypto_metadata";
          field.Type = TType.Struct;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          Crypto_metadata.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Encrypted_column_metadata != null && __isset.encrypted_column_metadata) {
          field.Name = "encrypted_column_metadata";
          field.Type = TType.String;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Encrypted_column_metadata);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ColumnChunk(");
      bool __first = true;
      if (File_path != null && __isset.file_path) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("File_path: ");
        __sb.Append(File_path);
      }
      if(!__first) { __sb.Append(", "); }
      __sb.Append("File_offset: ");
      __sb.Append(File_offset);
      if (Meta_data != null && __isset.meta_data) {
        __sb.Append(", Meta_data: ");
        __sb.Append(Meta_data== null ? "<null>" : Meta_data.ToString());
      }
      if (__isset.offset_index_offset) {
        __sb.Append(", Offset_index_offset: ");
        __sb.Append(Offset_index_offset);
      }
      if (__isset.offset_index_length) {
        __sb.Append(", Offset_index_length: ");
        __sb.Append(Offset_index_length);
      }
      if (__isset.column_index_offset) {
        __sb.Append(", Column_index_offset: ");
        __sb.Append(Column_index_offset);
      }
      if (__isset.column_index_length) {
        __sb.Append(", Column_index_length: ");
        __sb.Append(Column_index_length);
      }
      if (Crypto_metadata != null && __isset.crypto_metadata) {
        __sb.Append(", Crypto_metadata: ");
        __sb.Append(Crypto_metadata== null ? "<null>" : Crypto_metadata.ToString());
      }
      if (Encrypted_column_metadata != null && __isset.encrypted_column_metadata) {
        __sb.Append(", Encrypted_column_metadata: ");
        __sb.Append(Encrypted_column_metadata);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member