using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using NSubstitute;

public class TrapTests
{
    [Test]
    public void PlayerEntering_PlayerTargetedTrap_ReducesHealthByone()
    {
        Trap trap = new Trap();
        IPlayer player = Substitute.For<IPlayer>();
        player.IsPlayer.Returns(true);

        trap.HandleCharacterEntered(player, TrapTargetType.Player);

        Assert.AreEqual(-1, player.Health);
    }

    [Test]
    public void NPCEntering_NPCTargetedTrap_ReducesHealthByone()
    {
        Trap trap = new Trap();
        IPlayer player = Substitute.For<IPlayer>();
        trap.HandleCharacterEntered(player, TrapTargetType.NPC);
        Assert.AreEqual(-1, player.Health);
    }
}
