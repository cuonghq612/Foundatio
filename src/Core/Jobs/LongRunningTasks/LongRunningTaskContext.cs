using System;

namespace Foundatio.Jobs {
    public class LongRunningTaskContext {
        private readonly Action<int, string> _progressCallback;

        public LongRunningTaskContext(object data, Action<int, string> progressCallback) {
            Data = data;
            _progressCallback = progressCallback;
        }

        public object Data { get; private set; }

        public void ReportProgress(int progress, string message = null) {
            _progressCallback(progress, message);
        }

        public T GetData<T>() where T : class {
            return Data as T;
        }
    }
}