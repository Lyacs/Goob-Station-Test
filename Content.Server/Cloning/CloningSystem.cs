// SPDX-FileCopyrightText: 2020 Exp <theexp111@gmail.com>
// SPDX-FileCopyrightText: 2020 SoulSloth <67545203+SoulSloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2021 20kdc <asdd2808@gmail.com>
// SPDX-FileCopyrightText: 2021 Acruid <shatter66@gmail.com>
// SPDX-FileCopyrightText: 2021 Galactic Chimp <63882831+GalacticChimp@users.noreply.github.com>
// SPDX-FileCopyrightText: 2021 Metal Gear Sloth <metalgearsloth@gmail.com>
// SPDX-FileCopyrightText: 2021 Silver <silvertorch5@gmail.com>
// SPDX-FileCopyrightText: 2021 Vera Aguilera Puerto <6766154+Zumorica@users.noreply.github.com>
// SPDX-FileCopyrightText: 2021 Vera Aguilera Puerto <gradientvera@outlook.com>
// SPDX-FileCopyrightText: 2021 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 0x6273 <0x40@keemail.me>
// SPDX-FileCopyrightText: 2022 EmoGarbage404 <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Flipp Syder <76629141+vulppine@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Javier Guardia Fernández <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Moony <moonheart08@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
// SPDX-FileCopyrightText: 2022 fishfish458 <fishfish458>
// SPDX-FileCopyrightText: 2022 och-och <80923370+och-och@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 AJCM-git <60196617+AJCM-git@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <drsmugleaf@gmail.com>
// SPDX-FileCopyrightText: 2023 ElectroJr <leonsfriedrich@gmail.com>
// SPDX-FileCopyrightText: 2023 Emisse <99158783+Emisse@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Jezithyr <jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2023 Julian Giebel <juliangiebel@live.de>
// SPDX-FileCopyrightText: 2023 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 OctoRocket <88291550+OctoRocket@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Pieter-Jan Briers <pieterjan.briers@gmail.com>
// SPDX-FileCopyrightText: 2023 Rane <60792108+Elijahrane@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 ShadowCommander <10494922+ShadowCommander@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Visne <39844191+Visne@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 brainfood1183 <113240905+brainfood1183@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 corentt <36075110+corentt@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 keronshb <54602815+keronshb@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2024 Errant <35878406+Errant-4@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Kara <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Scribbles0 <91828755+Scribbles0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 TemporalOroboros <TemporalOroboros@gmail.com>
// SPDX-FileCopyrightText: 2024 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 username <113782077+whateverusername0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 whateverusername0 <whateveremail>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ScarKy0 <106310278+ScarKy0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <@deltanedas:kde.org>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Server.Atmos.EntitySystems;
using Content.Server.Chat.Systems;
using Content.Server.Cloning.Components;
using Content.Server.DeviceLinking.Systems;
using Content.Server.EUI;
using Content.Server.Fluids.EntitySystems;
using Content.Server.Humanoid;
using Content.Server.Jobs;
using Content.Server.Materials;
using Content.Server.Popups;
using Content.Server.Power.EntitySystems;
using Content.Shared._EinsteinEngines.Silicon.Components; // Goobstation
using Content.Shared.Atmos;
using Content.Shared.CCVar;
using Content.Shared.Chemistry.Components;
using Content.Shared.Cloning;
using Content.Shared.Damage;
using Content.Shared.DeviceLinking.Events;
using Content.Shared.Emag.Components;
using Content.Shared.Emag.Systems;
using Content.Shared.Examine;
using Content.Shared.GameTicking;
using Content.Shared.Humanoid;
using Content.Shared.Mind;
using Content.Shared.Mind.Components;
using Content.Shared.Mobs.Systems;
using Content.Shared.Roles.Jobs;
using Robust.Server.Containers;
using Robust.Server.GameObjects;
using Robust.Server.Player;
using Robust.Shared.Audio.Systems;
using Robust.Shared.Configuration;
using Robust.Shared.Containers;
using Robust.Shared.Physics.Components;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Server.Cloning
{
    public sealed class CloningSystem : EntitySystem
    {
        [Dependency] private readonly DeviceLinkSystem _signalSystem = default!;
        [Dependency] private readonly IPlayerManager _playerManager = null!;
        [Dependency] private readonly IPrototypeManager _prototype = default!;
        [Dependency] private readonly EuiManager _euiManager = null!;
        [Dependency] private readonly CloningConsoleSystem _cloningConsoleSystem = default!;
        [Dependency] private readonly HumanoidAppearanceSystem _humanoidSystem = default!;
        [Dependency] private readonly ContainerSystem _containerSystem = default!;
        [Dependency] private readonly MobStateSystem _mobStateSystem = default!;
        [Dependency] private readonly PowerReceiverSystem _powerReceiverSystem = default!;
        [Dependency] private readonly IRobustRandom _robustRandom = default!;
        [Dependency] private readonly AtmosphereSystem _atmosphereSystem = default!;
        [Dependency] private readonly TransformSystem _transformSystem = default!;
        [Dependency] private readonly SharedAppearanceSystem _appearance = default!;
        [Dependency] private readonly PuddleSystem _puddleSystem = default!;
        [Dependency] private readonly ChatSystem _chatSystem = default!;
        [Dependency] private readonly SharedAudioSystem _audio = default!;
        [Dependency] private readonly IConfigurationManager _configManager = default!;
        [Dependency] private readonly MaterialStorageSystem _material = default!;
        [Dependency] private readonly PopupSystem _popupSystem = default!;
        [Dependency] private readonly SharedMindSystem _mindSystem = default!;
        [Dependency] private readonly MetaDataSystem _metaSystem = default!;
        [Dependency] private readonly SharedJobSystem _jobs = default!;
        [Dependency] private readonly EmagSystem _emag = default!;

        public readonly Dictionary<MindComponent, EntityUid> ClonesWaitingForMind = new();
        public const float EasyModeCloningCost = 0.7f;

        public override void Initialize()
        {
            base.Initialize();

            SubscribeLocalEvent<CloningPodComponent, ComponentInit>(OnComponentInit);
            SubscribeLocalEvent<RoundRestartCleanupEvent>(Reset);
            SubscribeLocalEvent<BeingClonedComponent, MindAddedMessage>(HandleMindAdded);
            SubscribeLocalEvent<CloningPodComponent, PortDisconnectedEvent>(OnPortDisconnected);
            SubscribeLocalEvent<CloningPodComponent, AnchorStateChangedEvent>(OnAnchor);
            SubscribeLocalEvent<CloningPodComponent, ExaminedEvent>(OnExamined);
            SubscribeLocalEvent<CloningPodComponent, GotEmaggedEvent>(OnEmagged);
        }

        private void OnComponentInit(EntityUid uid, CloningPodComponent clonePod, ComponentInit args)
        {
            clonePod.BodyContainer = _containerSystem.EnsureContainer<ContainerSlot>(uid, "clonepod-bodyContainer");
            _signalSystem.EnsureSinkPorts(uid, CloningPodComponent.PodPort);
        }

        // GoobStation: rewrite so it uses BeingClonedComponent instead of a dictionary
        internal void TransferMindToClone(EntityUid mindId, MindComponent mind)
        {
            // find first mob this player is meant to use and doesn't already have a mind via alternate means
            var query = EntityQueryEnumerator<BeingClonedComponent, MindContainerComponent>();
            var found = false;
            EntityUid mob;
            while (query.MoveNext(out mob, out var cloned, out var mc))
            {
                if (cloned.Mind == mind && mc.Mind == null)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                return;

            _mindSystem.TransferTo(mindId, mob, ghostCheckOverride: true, mind: mind);
            _mindSystem.UnVisit(mindId, mind);
        }

        private void HandleMindAdded(EntityUid uid, BeingClonedComponent clonedComponent, MindAddedMessage message)
        {
            if (clonedComponent.Parent == EntityUid.Invalid ||
                !EntityManager.EntityExists(clonedComponent.Parent) ||
                !TryComp<CloningPodComponent>(clonedComponent.Parent, out var cloningPodComponent) ||
                uid != cloningPodComponent.BodyContainer.ContainedEntity)
            {
                EntityManager.RemoveComponent<BeingClonedComponent>(uid);
                return;
            }
            UpdateStatus(clonedComponent.Parent, CloningPodStatus.Cloning, cloningPodComponent);
        }

        private void OnPortDisconnected(EntityUid uid, CloningPodComponent pod, PortDisconnectedEvent args)
        {
            pod.ConnectedConsole = null;
        }

        private void OnAnchor(EntityUid uid, CloningPodComponent component, ref AnchorStateChangedEvent args)
        {
            if (component.ConnectedConsole == null || !TryComp<CloningConsoleComponent>(component.ConnectedConsole, out var console))
                return;

            if (args.Anchored)
            {
                _cloningConsoleSystem.RecheckConnections(component.ConnectedConsole.Value, uid, console.GeneticScanner, console);
                return;
            }
            _cloningConsoleSystem.UpdateUserInterface(component.ConnectedConsole.Value, console);
        }

        private void OnExamined(EntityUid uid, CloningPodComponent component, ExaminedEvent args)
        {
            if (!args.IsInDetailsRange || !_powerReceiverSystem.IsPowered(uid))
                return;

            args.PushMarkup(Loc.GetString("cloning-pod-biomass", ("number", _material.GetMaterialAmount(uid, component.RequiredMaterial))));
        }

        public bool TryCloning(EntityUid uid, EntityUid bodyToClone, Entity<MindComponent> mindEnt, CloningPodComponent? clonePod, float failChanceModifier = 1)
        {
            if (!Resolve(uid, ref clonePod))
                return false;

            if (HasComp<ActiveCloningPodComponent>(uid))
                return false;

            var mind = mindEnt.Comp;
            // GoobStation: Remove this logic entirely, infinite clone army
            /*if (ClonesWaitingForMind.TryGetValue(mind, out var clone))
            {
                if (EntityManager.EntityExists(clone) &&
                    !_mobStateSystem.IsDead(clone) &&
                    TryComp<MindContainerComponent>(clone, out var cloneMindComp) &&
                    (cloneMindComp.Mind == null || cloneMindComp.Mind == mindEnt))
                    return false; // Mind already has clone

                ClonesWaitingForMind.Remove(mind);
            }*/

            // GoobStation: Lets you clone living people
            //if (mind.OwnedEntity != null && !_mobStateSystem.IsDead(mind.OwnedEntity.Value))
            //    return false; // Body controlled by mind is not dead

            // Yes, we still need to track down the client because we need to open the Eui
            if (mind.UserId == null || !_playerManager.TryGetSessionById(mind.UserId.Value, out var client))
                return false; // If we can't track down the client, we can't offer transfer. That'd be quite bad.

            if (!TryComp<HumanoidAppearanceComponent>(bodyToClone, out var humanoid))
                return false; // whatever body was to be cloned, was not a humanoid

            if (HasComp<SiliconComponent>(bodyToClone))
                return false; // Goobstation: Don't clone IPCs.

            if (!_prototype.TryIndex(humanoid.Species, out var speciesPrototype))
                return false;

            if (!TryComp<PhysicsComponent>(bodyToClone, out var physics))
                return false;

            var cloningCost = (int) Math.Round(physics.FixturesMass);

            if (_configManager.GetCVar(CCVars.BiomassEasyMode))
                cloningCost = (int) Math.Round(cloningCost * EasyModeCloningCost);

            // biomass checks
            var biomassAmount = _material.GetMaterialAmount(uid, clonePod.RequiredMaterial);

            if (biomassAmount < cloningCost)
            {
                if (clonePod.ConnectedConsole != null)
                    _chatSystem.TrySendInGameICMessage(clonePod.ConnectedConsole.Value, Loc.GetString("cloning-console-chat-error", ("units", cloningCost)), InGameICChatType.Speak, false);
                return false;
            }

            _material.TryChangeMaterialAmount(uid, clonePod.RequiredMaterial, -cloningCost);
            clonePod.UsedBiomass = cloningCost;
            // end of biomass checks

            // genetic damage checks
            if (TryComp<DamageableComponent>(bodyToClone, out var damageable) &&
                damageable.Damage.DamageDict.TryGetValue("Cellular", out var cellularDmg))
            {
                var chance = Math.Clamp((float) (cellularDmg / 100), 0, 1);
                chance *= failChanceModifier;

                if (cellularDmg > 0 && clonePod.ConnectedConsole != null)
                    _chatSystem.TrySendInGameICMessage(clonePod.ConnectedConsole.Value, Loc.GetString("cloning-console-cellular-warning", ("percent", Math.Round(100 - chance * 100))), InGameICChatType.Speak, false);

                if (_robustRandom.Prob(chance))
                {
                    UpdateStatus(uid, CloningPodStatus.Gore, clonePod);
                    clonePod.FailedClone = true;
                    AddComp<ActiveCloningPodComponent>(uid);
                    return true;
                }
            }
            // end of genetic damage checks

            var mob = Spawn(speciesPrototype.Prototype, _transformSystem.GetMapCoordinates(uid));
            _humanoidSystem.CloneAppearance(bodyToClone, mob);

            var ev = new CloningEvent(bodyToClone, mob);
            RaiseLocalEvent(bodyToClone, ref ev);

            if (!ev.NameHandled)
                _metaSystem.SetEntityName(mob, MetaData(bodyToClone).EntityName);

            var cloneMindReturn = EntityManager.AddComponent<BeingClonedComponent>(mob);
            cloneMindReturn.Mind = mind;
            cloneMindReturn.Parent = uid;
            _containerSystem.Insert(mob, clonePod.BodyContainer);
            //ClonesWaitingForMind.Add(mind, mob); // GoobStation: Use mindId
            UpdateStatus(uid, CloningPodStatus.NoMind, clonePod);
            _euiManager.OpenEui(new AcceptCloningEui(mindEnt, mind, this), client);

            AddComp<ActiveCloningPodComponent>(uid);

            // TODO: Ideally, components like this should be components on the mind entity so this isn't necessary.
            // Add on special job components to the mob.
            if (_jobs.MindTryGetJob(mindEnt, out var prototype))
            {
                foreach (var special in prototype.Special)
                {
                    if (special is AddComponentSpecial)
                        special.AfterEquip(mob);
                }
            }

            return true;
        }

        public void UpdateStatus(EntityUid podUid, CloningPodStatus status, CloningPodComponent cloningPod)
        {
            cloningPod.Status = status;
            _appearance.SetData(podUid, CloningPodVisuals.Status, cloningPod.Status);
        }

        public override void Update(float frameTime)
        {
            var query = EntityQueryEnumerator<ActiveCloningPodComponent, CloningPodComponent>();
            while (query.MoveNext(out var uid, out var _, out var cloning))
            {
                if (!_powerReceiverSystem.IsPowered(uid))
                    continue;

                if (cloning.BodyContainer.ContainedEntity == null && !cloning.FailedClone)
                    continue;

                cloning.CloningProgress += frameTime;
                if (cloning.CloningProgress < cloning.CloningTime)
                    continue;

                if (cloning.FailedClone)
                    EndFailedCloning(uid, cloning);
                else
                    Eject(uid, cloning);
            }
        }

        /// <summary>
        /// On emag, spawns a failed clone when cloning process fails which attacks nearby crew.
        /// </summary>
        private void OnEmagged(EntityUid uid, CloningPodComponent clonePod, ref GotEmaggedEvent args)
        {
            if (!_emag.CompareFlag(args.Type, EmagType.Interaction))
                return;

            if (_emag.CheckFlag(uid, EmagType.Interaction))
                return;

            if (!this.IsPowered(uid, EntityManager))
                return;

            _popupSystem.PopupEntity(Loc.GetString("cloning-pod-component-upgrade-emag-requirement"), uid);
            args.Handled = true;
        }

        public void Eject(EntityUid uid, CloningPodComponent? clonePod)
        {
            if (!Resolve(uid, ref clonePod))
                return;

            if (clonePod.BodyContainer.ContainedEntity is not { Valid: true } entity || clonePod.CloningProgress < clonePod.CloningTime)
                return;

            EntityManager.RemoveComponent<BeingClonedComponent>(entity);
            _containerSystem.Remove(entity, clonePod.BodyContainer);
            clonePod.CloningProgress = 0f;
            clonePod.UsedBiomass = 0;
            UpdateStatus(uid, CloningPodStatus.Idle, clonePod);
            RemCompDeferred<ActiveCloningPodComponent>(uid);
        }

        private void EndFailedCloning(EntityUid uid, CloningPodComponent clonePod)
        {
            clonePod.FailedClone = false;
            clonePod.CloningProgress = 0f;
            UpdateStatus(uid, CloningPodStatus.Idle, clonePod);
            var transform = Transform(uid);
            var indices = _transformSystem.GetGridTilePositionOrDefault((uid, transform));
            var tileMix = _atmosphereSystem.GetTileMixture(transform.GridUid, null, indices, true);

            if (_emag.CheckFlag(uid, EmagType.Interaction))
            {
                _audio.PlayPvs(clonePod.ScreamSound, uid);
                Spawn(clonePod.MobSpawnId, transform.Coordinates);
            }

            Solution bloodSolution = new();

            var i = 0;
            while (i < 1)
            {
                tileMix?.AdjustMoles(Gas.Ammonia, 6f);
                bloodSolution.AddReagent("Blood", 50);
                if (_robustRandom.Prob(0.2f))
                    i++;
            }
            _puddleSystem.TrySpillAt(uid, bloodSolution, out _);

            if (!_emag.CheckFlag(uid, EmagType.Interaction))
            {
                _material.SpawnMultipleFromMaterial(_robustRandom.Next(1, (int) (clonePod.UsedBiomass / 2.5)), clonePod.RequiredMaterial, Transform(uid).Coordinates);
            }

            clonePod.UsedBiomass = 0;
            RemCompDeferred<ActiveCloningPodComponent>(uid);
        }

        public void Reset(RoundRestartCleanupEvent ev)
        {
            ClonesWaitingForMind.Clear();
        }
    }
}