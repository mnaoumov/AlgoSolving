// https://pastebin.com/P4LtiZYb
// TLE?

  ListNode* detectCycle(ListNode* head) {
        if (!head) return nullptr;
        ListNode* slow = head;
        ListNode* quick = head->next;
        
        while(quick && quick->next && slow != quick) {
            slow = slow->next;
            quick = quick->next->next;
        }
        
        if (slow != quick) return nullptr;
        
        int cycle_len = 0;
        quick = slow->next;
        while (quick != slow) {
            quick = quick->next;
            ++cycle_len;
        }
        
        slow = head;
        quick = head;
        for (int i = 0; i < cycle_len; ++i) quick = quick->next;
        
        while(slow != quick) {
            slow = slow->next;
            quick = quick->next;
        }
        
        return slow;
    }