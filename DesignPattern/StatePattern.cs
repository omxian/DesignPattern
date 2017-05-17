using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    class StatePattern
    {
        /*
            State Pattern（状态模式）
            允许对象在内部状态改变时改变他的行为，
            对象看起来好像修改了它的类。
         
            类图和策略模式一样，但是他的意图不一样。
         */
        public StatePattern()
        {
            new StateMachine();
        }
    }

    public class StateMachine
    {
        public State idleState;
        public State runToEnemyState;
        public State runBackState;
        public State attackState;
        private State currentState;

        public StateMachine()
        {
            idleState = new ActorIdleState(this);
            runToEnemyState = new ActorRunToEnemyState(this);
            attackState = new ActorAttackState(this);
            runBackState = new ActorRunBackState(this);
            currentState = idleState;
            currentState.Idle();
            SetCurrentState(runToEnemyState);
            currentState.RunToEnemy();
            currentState.Attack();
            currentState.RunBack();
            currentState.Idle();
        }

        public void SetCurrentState(State state)
        {
            currentState = state;
        }

        public State GetIdleState()
        {
            return idleState;
        }

        public State GetAttackState()
        {
            return attackState;
        }

        public State GetRunToEnemyState()
        {
            return runToEnemyState;
        }
        public State GetRunBackState()
        {
            return runBackState;
        }
    }

    public class ActorIdleState : State
    {
        public ActorIdleState(StateMachine machine): base(machine)
        {
        }
        public override void Idle()
        {
            Console.WriteLine("Actor Idle");
        }
    }

    public class ActorRunBackState : State
    {
        public ActorRunBackState(StateMachine machine): base(machine)
        {
        }
        public override void RunBack()
        {
            Console.WriteLine("Actor RunBack");
            machine.SetCurrentState(machine.GetIdleState());
        }
    }
    public class ActorRunToEnemyState : State
    {
        public ActorRunToEnemyState(StateMachine machine): base(machine)
        {
        }
        public override void RunToEnemy()
        {
            Console.WriteLine("Actor RunToEnemy");
            machine.SetCurrentState(machine.GetAttackState());
        }
    }
    public class ActorAttackState : State
    {
        public ActorAttackState(StateMachine machine): base(machine)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("Actor Attack");
            machine.SetCurrentState(machine.GetRunBackState());
        }
    }

    public abstract class State
    {
        protected StateMachine machine;
        public State(StateMachine machine)
        {
            this.machine = machine;
        }

        public virtual void Idle()
        {
             throw new NotImplementedException();
        }
        public virtual void RunToEnemy()
        {
            throw new NotImplementedException();
        }
        public virtual void RunBack()
        {
            throw new NotImplementedException();
        }
        public virtual void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
