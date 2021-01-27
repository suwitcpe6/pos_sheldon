Public Class Tender_LogModel

	Private _TID As Integer
	Public Property TID() As Integer
		Get
			Return _TID
		End Get
		Set(value As Integer)
			_TID = value
		End Set
	End Property

	Private _TENDERCODE As String
	Public Property TENDERCODE() As String
		Get
			Return _TENDERCODE
		End Get
		Set(value As String)
			_TENDERCODE = value
		End Set
	End Property

	Private _DOCNO As String
	Public Property DOCNO() As String
		Get
			Return _DOCNO
		End Get
		Set(value As String)
			_DOCNO = value
		End Set
	End Property

	Private _TENDERDOCNO As String
	Public Property TENDERDOCNO() As String
		Get
			Return _TENDERDOCNO
		End Get
		Set(value As String)
			_TENDERDOCNO = value
		End Set
	End Property

	Private _TERMINALID As String
	Public Property TERMINALID() As String
		Get
			Return _TERMINALID
		End Get
		Set(value As String)
			_TERMINALID = value
		End Set
	End Property

	Private _POSID As String
	Public Property POSID() As String
		Get
			Return _POSID
		End Get
		Set(value As String)
			_POSID = value
		End Set
	End Property

	Private _MERCHAND_ID As String
	Public Property MERCHAND_ID() As String
		Get
			Return _MERCHAND_ID
		End Get
		Set(value As String)
			_MERCHAND_ID = value
		End Set
	End Property

	Private _LOG_TYPE As String
	Public Property LOG_TYPE() As String
		Get
			Return _LOG_TYPE
		End Get
		Set(value As String)
			_LOG_TYPE = value
		End Set
	End Property

	Private _DATA_TYPE As String
	Public Property DATA_TYPE() As String
		Get
			Return _DATA_TYPE
		End Get
		Set(value As String)
			_DATA_TYPE = value
		End Set
	End Property

	Private _DATA1 As String
	Public Property DATA1() As String
		Get
			Return _DATA1
		End Get
		Set(value As String)
			_DATA1 = value
		End Set
	End Property

	Private _DATA2 As String
	Public Property DATA2() As String
		Get
			Return _DATA2
		End Get
		Set(value As String)
			_DATA2 = value
		End Set
	End Property

	Private _REMARK1 As String
	Public Property REMARK1() As String
		Get
			Return _REMARK1
		End Get
		Set(value As String)
			_REMARK1 = value
		End Set
	End Property

	Private _REMARK2 As String
	Public Property REMARK2() As String
		Get
			Return _REMARK2
		End Get
		Set(value As String)
			_REMARK2 = value
		End Set
	End Property

	Private _REMARK3 As String
	Public Property REMARK3() As String
		Get
			Return _REMARK3
		End Get
		Set(value As String)
			_REMARK3 = value
		End Set
	End Property

	Private _STATUS As String
	Public Property STATUS() As String
		Get
			Return _STATUS
		End Get
		Set(value As String)
			_STATUS = value
		End Set
	End Property

	Private _CBY As String
	Public Property CBY() As String
		Get
			Return _CBY
		End Get
		Set(value As String)
			_CBY = value
		End Set
	End Property

	Private _CDATE As DateTime
	Public Property [CDATE]() As DateTime
		Get
			Return _CDATE
		End Get
		Set(value As DateTime)
			_CDATE = value
		End Set
	End Property

	Private _MBY As String
	Public Property MBY() As String
		Get
			Return _MBY
		End Get
		Set(value As String)
			_MBY = value
		End Set
	End Property

	Private _MODATE As DateTime
	Public Property MODATE() As DateTime
		Get
			Return _MODATE
		End Get
		Set(value As DateTime)
			_MODATE = value
		End Set
	End Property

End Class
