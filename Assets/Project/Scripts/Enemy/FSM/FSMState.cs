using System;

[Serializable]
    public class FSMState
    {
        public string ID;
        public FSMAction[] Actions;
        public FSMTransition[] Transitions;

        public void UpdateState()
        {
            ExcuteAction();
        }
        private void ExcuteAction()
        {
            for (int i = 0; i < Actions.Length; i++)
            {
                Actions[i].Act();
            }
        }

    }
