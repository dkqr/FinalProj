namespace KeyHandler {
    abstract class KeyListener {
        protected bool accepting;
        public abstract void OnKeyPress(ConsoleKeyInfo cki);        
        public void OnKeyDown(ConsoleKeyInfo cki) {
        }
        public KeyListener(KeyHandler kh) {
            kh.AddEvent(this);
        }
        public bool IsAccepting() {
            return accepting;
        }
    }
    class KeyHandler {
        private KeyListener[] events = new KeyListener[0];
        // WIORJKIOAENF OB TGIS 
        // (dont)
        public KeyHandler() {
            new Thread(() => {
                while (true) {
                    while (Console.KeyAvailable) {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (events != null && events.Length > 0)
                            foreach (KeyListener ke in events) {
                                if (ke.IsAccepting())
                                    ke.OnKeyPress(key);
                            }                  
                    } 
                }
            }).Start();
        }
        public void AddEvent(KeyListener kl) {
            events = events.Append(kl).ToArray();
        }
    }
}