using System;

[Serializable]
    public class FSMState
    {
        public string ID;
        public FSMAction[] Actions;
        public FSMTransition[] Transitions;

        public void UpdateState(EnemyBrain enemyBrain)
        {
            ExcuteAction();
            ExcuteTransition(enemyBrain);
        }

        private void ExcuteTransition(EnemyBrain enemyBrain)
        {
            if (Transitions == null || Transitions.Length <= 0) return;

            for (int i = 0; i < Transitions.Length; i++)
            {
                bool value = Transitions[i].Decision.Decide();
                if (value)
                {
                    enemyBrain.ChangeState(Transitions[i].TrueState);
                }
                else
                {
                    enemyBrain.ChangeState(Transitions[i].FalseState);
                    
                }
            }
        }

        private void ExcuteAction()
        {
            for (int i = 0; i < Actions.Length; i++)
            {
                Actions[i].Act();
            }
        }

    }
