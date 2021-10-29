Imports GTA

Module BasicQuicks
    ''' <summary>
    ''' Gets the player character.
    ''' </summary>
    ''' <returns>The player character.</returns>
    Public ReadOnly Property PChara As Ped
        Get
            Return Game.Player.Character
        End Get
    End Property

    ''' <summary>
    ''' Gets the player's current vehicle.
    ''' </summary>
    ''' <returns>If player's in vehicle, player's current vehicle; otherwise, <see langword="Nothing"/>.</returns>
    Public ReadOnly Property PVehicle As Vehicle
        Get
            Return Game.Player.Character.CurrentVehicle
        End Get
    End Property
End Module
