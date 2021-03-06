﻿
namespace cocos2d
{
    public class CCCallFuncN : CCCallFunc
    {
        private SEL_CallFuncN m_pCallFuncN;

        public CCCallFuncN()
        {
            m_pCallFuncN = null;
        }


        public static CCCallFuncN Create(SEL_CallFuncN selector)
        {
            var pRet = new CCCallFuncN();
            pRet.InitWithTarget(selector);
            return pRet;
        }

        public bool InitWithTarget(SEL_CallFuncN selector)
        {
            m_pCallFuncN = selector;
            return false;
        }

        public override object Copy(ICopyable zone)
        {
            CCCallFuncN pRet;

            if (zone != null)
            {
                //in case of being called at sub class
                pRet = (CCCallFuncN) (zone);
            }
            else
            {
                pRet = new CCCallFuncN();
                zone =  (pRet);
            }

            base.Copy(zone);

            pRet.InitWithTarget(m_pCallFuncN);

            return pRet;
        }

        public override void Execute()
        {
            if (null != m_pCallFuncN)
            {
                m_pCallFuncN(m_pTarget);
            }
            //if (m_nScriptHandler) {
            //    CCScriptEngineManager::sharedManager()->getScriptEngine()->executeFunctionWithobject(m_nScriptHandler, m_pTarget, "CCNode");
            //}
        }
    }
}